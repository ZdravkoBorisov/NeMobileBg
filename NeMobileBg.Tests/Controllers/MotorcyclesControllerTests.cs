using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NeMobileBg.Common.Models.Motorcycles;
using NeMobileBg.Data.Models;
using NeMobileBg.Services.Contracts;
using NeMobileBg.Web.Controllers;
using Xunit;

namespace NeMobileBg.Tests.Controllers
{
    public class MotorcyclesControllerTests
    {
        private readonly Mock<IMotorcycleService> _motorcycleServiceMock;
        private readonly Mock<UserManager<ApplicationUser>> _userManagerMock;
        private readonly MotorcyclesController _controller;

        public MotorcyclesControllerTests()
        {
            _motorcycleServiceMock = new Mock<IMotorcycleService>();
            _userManagerMock = MockUserManager<ApplicationUser>();

            _controller = new MotorcyclesController(_motorcycleServiceMock.Object, _userManagerMock.Object);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    User = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, "testuser"),
                        new Claim(ClaimTypes.NameIdentifier, "1"),
                    }))
                }
            };
        }

        private Mock<UserManager<TUser>> MockUserManager<TUser>() where TUser : class
        {
            var store = new Mock<IUserStore<TUser>>();
            var userManagerMock = new Mock<UserManager<TUser>>(store.Object, null, null, null, null, null, null, null, null);
            return userManagerMock;
        }

        private List<MotorcyclesSearchResponseModel> InitializeMotorcyclesData()
        {
            return new List<MotorcyclesSearchResponseModel>
            {
                new MotorcyclesSearchResponseModel
                {
                    MotorcycleId = "1",
                    Make = "Honda",
                    Model = "CBR",
                },
                new MotorcyclesSearchResponseModel
                {
                    MotorcycleId = "2",
                    Make = "Yamaha",
                    Model = "YZF",
                }
            };
        }

        private MotorcyclesSearchModel InitializeSearchModel()
        {
            return new MotorcyclesSearchModel
            {
                Make = "Honda",
                Model = "CBR",
            };
        }

        [Fact]
        public async Task Search_Post_ReturnsViewWithMotorcyclesData()
        {
            var searchModel = new MotorcyclesSearchModel
            {
                Make = "Honda",
                Category = "sport",
            };

            var motorcyclesData = new List<MotorcyclesSearchResponseModel>
            {
                new MotorcyclesSearchResponseModel
                {
                    MotorcycleId = "1",
                    Make = "Honda",
                    Model = "CBR",
                },
            };

            _userManagerMock.Setup(u => u.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns("1");
            _motorcycleServiceMock.Setup(s => s.GetBySearchCriteriaAsync(searchModel)).ReturnsAsync(motorcyclesData);


            var result = await _controller.Search() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal("GetSearch", result.ViewName);
            Assert.Equal(motorcyclesData, motorcyclesData);
        }

        [Fact]
        public async Task Search_Post_ReturnsViewWithNoData()
        {
            var searchModel = new MotorcyclesSearchModel
            {
                // Initialize search criteria
            };

            _userManagerMock.Setup(u => u.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns("1");
            _motorcycleServiceMock.Setup(s => s.GetMotorcyclesSearchDataAsync()).ReturnsAsync((IEnumerable<MotorcyclesSearchModel>)null);

            var result = await _controller.Search() as OkResult;

            Assert.NotNull(result);
        }


        [Fact]
        public async Task Create_Post_ReturnsRedirectToDetails()
        {
            var ownerId = "1";
            var motorcycleData = new MotorcyclesDataModel
            {
                Make = "Honda",
                Model = "CBR",
            };

            var motorcycleId = "123";
            _userManagerMock.Setup(u => u.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns(ownerId);
            _motorcycleServiceMock.Setup(s => s.CreateAsync(motorcycleData, ownerId)).ReturnsAsync(motorcycleId);

            var result = await _controller.Create(motorcycleData) as RedirectToActionResult;

            Assert.NotNull(result);
            Assert.Equal("Details", result.ActionName);
            Assert.Equal(motorcycleId, result.RouteValues["id"]);
        }

        [Fact]
        public async Task Details_ReturnsViewWithMotorcycleData()
        {
            var motorcycleId = "123";
            var motorcycle = new MotorcyclesDataModel
            {
                Id = motorcycleId,
                Make = "Honda",
                Model = "CBR",
            };
            _userManagerMock.Setup(u => u.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns("1");
            _motorcycleServiceMock.Setup(s => s.GetDetailsAsync(motorcycleId)).ReturnsAsync(motorcycle);

            var result = await _controller.Details(motorcycleId) as ViewResult;

            Assert.NotNull(result);
            Assert.Equal(motorcycle, result.Model);
        }

        [Fact]
        public async Task Edit_Post_ReturnsRedirectToDetails()
        {
            var motorcycleId = "123";
            var editedMotorcycleData = new MotorcyclesDataModel
            {
                Id = motorcycleId,
                Make = "Yamaha",
                Model = "YZF",
            };

            _userManagerMock.Setup(u => u.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns("1");
            _motorcycleServiceMock.Setup(s => s.EditAsync(editedMotorcycleData));

            var result = await _controller.Edit(editedMotorcycleData) as RedirectToActionResult;

            Assert.NotNull(result);
            Assert.Equal("Details", result.ActionName);
            Assert.Equal(motorcycleId, result.RouteValues["id"]);
        }

        [Fact]
        public async Task Delete_Get_ReturnsRedirectToSearch()
        {
            var motorcycleId = "123";
            _userManagerMock.Setup(u => u.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns("1");

            var result = await _controller.Delete(motorcycleId) as RedirectToActionResult;

            Assert.NotNull(result);
            Assert.Equal("Search", result.ActionName);
        }
    }
}
