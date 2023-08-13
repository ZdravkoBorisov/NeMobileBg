using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Moq;
using NeMobileBg.Web.Controllers;
using NeMobileBg.Services.Contracts;
using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Data.Models;
using Xunit;

namespace NeMobileBg.Tests.Controllers;

public class CarsControllerTests
{
    [Fact]
    public async Task Search_Get_ReturnsViewWithModel()
    {
        var userManagerMock = MockUserManager.CreateMockUserManager();
        var carsServiceMock = new Mock<ICarsService>();
        carsServiceMock.Setup(s => s.GetCarsSearchDataAsync()).ReturnsAsync(new List<CarsSearchModel>());

        var controller = new CarsController(carsServiceMock.Object, userManagerMock.Object);

        var result = await controller.Search() as ViewResult;

        Assert.NotNull(result);
        Assert.Equal("GetSearch", result.ViewName);
        Assert.IsType<List<CarsSearchModel>>(result.Model);
    }

    [Fact]
    public async Task Create_Post_ValidModel_RedirectsToDetails()
    {
        var userManagerMock = MockUserManager.CreateMockUserManager();
        var carsServiceMock = new Mock<ICarsService>();
        carsServiceMock.Setup(s => s.CreateAsync(It.IsAny<CarsDataModel>(), It.IsAny<string>()))
            .ReturnsAsync("carId");

        var controller = new CarsController(carsServiceMock.Object, userManagerMock.Object);
        var carModel = new CarsDataModel();

        var result = await controller.Create(carModel) as RedirectToActionResult;

        Assert.NotNull(result);
        Assert.Equal("Details", result.ActionName);
        Assert.Equal("carId", result.RouteValues["id"]);
    }

    [Fact]
    public async Task Edit_Get_ReturnsViewWithModel()
    {
        var userManagerMock = MockUserManager.CreateMockUserManager();
        var carsServiceMock = new Mock<ICarsService>();
        carsServiceMock.Setup(s => s.GetDetailsAsync("carId"))
            .ReturnsAsync(new CarsDataModel());

        var controller = new CarsController(carsServiceMock.Object, userManagerMock.Object);

        var result = await controller.Edit("carId") as ViewResult;

        Assert.NotNull(result);
        Assert.IsType<CarsDataModel>(result.Model);
    }

    [Fact]
    public async Task Edit_Post_ValidModel_RedirectsToDetails()
    {
        var userManagerMock = MockUserManager.CreateMockUserManager();
        var carsServiceMock = new Mock<ICarsService>();
        carsServiceMock.Setup(s => s.EditAsync(It.IsAny<CarsDataModel>()))
            .Returns(Task.CompletedTask);

        var controller = new CarsController(carsServiceMock.Object, userManagerMock.Object);
        var carModel = new CarsDataModel { Id = "carId" };

        var result = await controller.Edit(carModel) as RedirectToActionResult;

        Assert.NotNull(result);
        Assert.Equal("Details", result.ActionName);
        Assert.Equal("carId", result.RouteValues["id"]);
    }

    [Fact]
    public async Task Delete_Get_RedirectsToSearch()
    {
        var userManagerMock = MockUserManager.CreateMockUserManager();
        var carsServiceMock = new Mock<ICarsService>();
        carsServiceMock.Setup(s => s.Delete("carId")).Returns(Task.CompletedTask);

        var controller = new CarsController(carsServiceMock.Object, userManagerMock.Object);

        var result = await controller.Delete("carId") as RedirectToActionResult;

        Assert.NotNull(result);
        Assert.Equal("Search", result.ActionName);
    }

    [Fact]
    public async Task Details_Get_ReturnsViewWithModel()
    {
        var userManagerMock = MockUserManager.CreateMockUserManager();
        var carsServiceMock = new Mock<ICarsService>();
        carsServiceMock.Setup(s => s.GetDetailsAsync("carId"))
            .ReturnsAsync(new CarsDataModel());

        var controller = new CarsController(carsServiceMock.Object, userManagerMock.Object);


        var result = await controller.Details("carId") as ViewResult;

        Assert.NotNull(result);
        Assert.IsType<CarsDataModel>(result.Model);
    }
}

public static class MockUserManager
{
    public static Mock<UserManager<ApplicationUser>> CreateMockUserManager()
    {
        var store = new Mock<IUserStore<ApplicationUser>>();
        return new Mock<UserManager<ApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
    }
}
