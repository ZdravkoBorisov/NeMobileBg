using Microsoft.AspNetCore.Http;
using Moq;
using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Data.Models;
using NeMobileBg.Data.Repository;
using NeMobileBg.Services.Cars;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace NeMobileBg.Tests.Services;

public class CarsServiceTests
{
    private readonly Mock<IRepository> _repositoryMock;
    private readonly CarsService _carsService;

    public CarsServiceTests()
    {
        _repositoryMock = new Mock<IRepository>();
        _carsService = new CarsService(_repositoryMock.Object);
    }

    [Fact]
    public async Task CreateAsync_WithValidData_ReturnsCarId()
    {
        var ownerId = "user1";
        var dataModel = new CarsDataModel
        {
            Make = "BMW",
            Model = "M5",
        };

        var formFileMock = new Mock<IFormFile>();
        formFileMock.Setup(file => file.CopyToAsync(It.IsAny<Stream>(), default)).Returns(Task.CompletedTask);

        _repositoryMock.Setup(repo => repo.AddAsync(It.IsAny<Car>())).Verifiable();
        _repositoryMock.Setup(repo => repo.SaveChangesAsync()); 

        var carId = await _carsService.CreateAsync(dataModel, ownerId);

        Assert.NotNull(carId);
        _repositoryMock.Verify();
    }
    [Fact]
    public async Task GetDetailsAsync_WithExistingId_ReturnsCarsDataModel()
    {
        var carId = "car1";
        var car = new Car
        {
            Id = carId,
            Make = "BMW",
            Model = "M5",

        };

        _repositoryMock.Setup(repo => repo.GetByIdAsync<Car>(carId)).ReturnsAsync(car);

        var result = await _carsService.GetDetailsAsync(carId);

        Assert.NotNull(result);
        Assert.Equal(car.Id, result.Id);
    }

    [Fact]
    public async Task GetDetailsAsync_WithNonExistingId_ReturnsNull()
    {
        var carId = "nonExistingCarId";

        _repositoryMock.Setup(repo => repo.GetByIdAsync<Car>(carId)).ReturnsAsync((Car)null);

        var result = await _carsService.GetDetailsAsync(carId);

        Assert.Null(result);
    }

    [Fact]
    public async Task EditAsync_UpdatesCarProperties()
    {
        var carId = "car1";
        var car = new Car
        {
            Id = carId,
            Make = "BMW",
            Model = "M5",
        };
        var editModel = new CarsDataModel
        {
            Id = carId,
            Make = "Toyota",
            Model = "Corolla",
        };

        _repositoryMock.Setup(repo => repo.GetByIdAsync<Car>(carId)).ReturnsAsync(car);

        await _carsService.EditAsync(editModel);

        _repositoryMock.Verify(repo => repo.UpdateAsync(car), Times.Once);
        _repositoryMock.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        Assert.Equal("Toyota", car.Make);
        Assert.Equal("Corolla", car.Model);
    }
    [Fact]
    public async Task GetDetailsAsync_ReturnsCarDetails_IfExists()
    {
        var carId = "car1";
        var car = new Car
        {
            Id = carId,
            Make = "BMW",
            Model = "M5",
        };

        _repositoryMock.Setup(repo => repo.GetByIdAsync<Car>(carId)).ReturnsAsync(car);

        var result = await _carsService.GetDetailsAsync(carId);

        Assert.NotNull(result);
        Assert.Equal(car.Id, result.Id);
        Assert.Equal(car.Make, result.Make);
        Assert.Equal(car.Model, result.Model);
    }

    [Fact]
    public async Task GetDetailsAsync_ReturnsNull_IfCarNotFound()
    {
        var carId = "car1";
        _repositoryMock.Setup(repo => repo.GetByIdAsync<Car>(carId)).ReturnsAsync((Car)null);

        var result = await _carsService.GetDetailsAsync(carId);

        Assert.Null(result);
    }

    [Fact]
    public async Task EditAsync_UpdatesCar_WithNewData()
    {
        var carId = "car1";
        var editModel = new CarsDataModel
        {
            Id = carId,
            Make = "Toyota",
            Model = "Supra",
        };

        var existingCar = new Car
        {
            Id = carId,
            Make = "BMW",
            Model = "M5",
        };

        _repositoryMock.Setup(repo => repo.GetByIdAsync<Car>(carId)).ReturnsAsync(existingCar);

        await _carsService.EditAsync(editModel);

        Assert.Equal(editModel.Make, existingCar.Make);
        Assert.Equal(editModel.Model, existingCar.Model);

        _repositoryMock.Verify(repo => repo.UpdateAsync(existingCar), Times.Once);
        _repositoryMock.Verify(repo => repo.SaveChangesAsync(), Times.Once);
    }
}
