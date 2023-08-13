using Microsoft.AspNetCore.Http;
using Moq;
using NeMobileBg.Common.Models.Motorcycles;
using NeMobileBg.Data.Models;
using NeMobileBg.Data.Repository;
using NeMobileBg.Services.Motorcycles;
using Xunit;

namespace NeMobileBg.Tests.Services;

public class MotorcyclesServiceTests
{
    private readonly Mock<IRepository> _repositoryMock;
    private readonly MotorcyclesService _motorcyclesService;

    public MotorcyclesServiceTests()
    {
        _repositoryMock = new Mock<IRepository>();
        _motorcyclesService = new MotorcyclesService(_repositoryMock.Object);
    }

    [Fact]
    public async Task CreateAsync_WithValidData_ReturnsMotorcycleId()
    {
        var ownerId = "user1";
        var dataModel = new MotorcyclesDataModel
        {
            Make = "Harley-Davidson",
            Model = "Street Glide",
        };

        var formFileMock = new Mock<IFormFile>();
        formFileMock.Setup(file => file.CopyToAsync(It.IsAny<Stream>(), default)).Returns(Task.CompletedTask);

        _repositoryMock.Setup(repo => repo.AddAsync(It.IsAny<Motorcycle>())).Verifiable();
        _repositoryMock.Setup(repo => repo.SaveChangesAsync());

        var motorcycleId = await _motorcyclesService.CreateAsync(dataModel, ownerId);

        Assert.NotNull(motorcycleId);
        _repositoryMock.Verify();
    }

    [Fact]
    public async Task DeleteAsync_WithValidId_DeletesMotorcycle()
    {
        var motorcycleId = "motorcycle1";

        _repositoryMock.Setup(repo => repo.GetByIdAsync<Motorcycle>(motorcycleId)).ReturnsAsync(new Motorcycle()).Verifiable();
        _repositoryMock.Setup(repo => repo.RemoveAsync(It.IsAny<Motorcycle>())).Verifiable();
        _repositoryMock.Setup(repo => repo.SaveChangesAsync());

        await _motorcyclesService.DeleteAsync(motorcycleId);

        _repositoryMock.Verify();
    }

    [Fact]
    public async Task EditAsync_WithValidData_UpdatesMotorcycle()
    {
        var editModel = new MotorcyclesDataModel
        {
            Id = "motorcycle1",
            Make = "Suzuki",
            Model = "GSX-R750",
        };

        var formFileMock = new Mock<IFormFile>();
        formFileMock.Setup(file => file.CopyToAsync(It.IsAny<Stream>(), default)).Returns(Task.CompletedTask);

        _repositoryMock.Setup(repo => repo.GetByIdAsync<Motorcycle>(editModel.Id)).ReturnsAsync(new Motorcycle()).Verifiable();
        _repositoryMock.Setup(repo => repo.UpdateAsync(It.IsAny<Motorcycle>())).Verifiable();
        _repositoryMock.Setup(repo => repo.SaveChangesAsync());

        await _motorcyclesService.EditAsync(editModel);

        _repositoryMock.Verify();
    }

    [Fact]
    public async Task GetBySearchCriteriaAsync_WithSearchModel_ReturnsMatchingMotorcycles()
    {
        var searchModel = new MotorcyclesSearchModel
        {
            Make = "Harley-Davidson",
            Model = "Street Glide",
        };

        var motorcycles = new List<Motorcycle>
    {
        new Motorcycle
        {
            Make = "Harley-Davidson",
            Model = "Street Glide",
        },
        new Motorcycle
        {
            Make = "Suzuki",
            Model = "GSX-R750",
        }
    };

        _repositoryMock.Setup(repo => repo.GetAllAsync<Motorcycle>()).ReturnsAsync(motorcycles.AsQueryable()).Verifiable();

        var result = await _motorcyclesService.GetBySearchCriteriaAsync(searchModel);

        Assert.NotNull(result);
        Assert.Equal(1, result.Count());
        Assert.Equal("Harley-Davidson", result.First().Make);
        Assert.Equal("Street Glide", result.First().Model);

        _repositoryMock.Verify();
    }

    [Fact]
    public async Task GetMotorcyclesSearchDataAsync_ReturnsMotorcyclesSearchData()
    {
        var motorcycles = new List<Motorcycle>
    {
        new Motorcycle
        {
            Make = "Harley-Davidson",
            Model = "Street Glide",
        },
        new Motorcycle
        {
            Make = "Suzuki",
            Model = "GSX-R750",
        }
    };

        _repositoryMock.Setup(repo => repo.GetAllAsync<Motorcycle>()).ReturnsAsync(motorcycles.AsQueryable()).Verifiable();

        var result = await _motorcyclesService.GetMotorcyclesSearchDataAsync();

        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Contains(result, m => m.Make == "Harley-Davidson");
        Assert.Contains(result, m => m.Make == "Suzuki");

        _repositoryMock.Verify();
    }

    [Fact]
    public async Task GetDetailsAsync_WithValidId_ReturnsMotorcycleDetails()
    {
        var motorcycleId = "motorcycle1";
        var motorcycle = new Motorcycle
        {
            Id = motorcycleId,
            Make = "Harley-Davidson",
            Model = "Street Glide",
        };

        _repositoryMock.Setup(repo => repo.GetByIdAsync<Motorcycle>(motorcycleId)).ReturnsAsync(motorcycle).Verifiable();

        var result = await _motorcyclesService.GetDetailsAsync(motorcycleId);

        Assert.NotNull(result);
        Assert.Equal(motorcycleId, result.Id);
        Assert.Equal("Harley-Davidson", result.Make);
        Assert.Equal("Street Glide", result.Model);

        _repositoryMock.Verify();
    }

}
