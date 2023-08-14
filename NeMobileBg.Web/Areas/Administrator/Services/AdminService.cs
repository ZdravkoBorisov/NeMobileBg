using Microsoft.AspNetCore.Identity;
using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Common.Models.Motorcycles;
using NeMobileBg.Data.Models;
using NeMobileBg.Services.Contracts;
using NeMobileBg.Web.Areas.Administrator.Services.Contracts;

namespace NeMobileBg.Web.Areas.Administrator.Services;

public class AdminService : IAdminService
{
    private readonly IUsersService _usersService;

    public AdminService(IUsersService usersService)
    {
        this._usersService = usersService;
    }

    public async Task<IEnumerable<CarsDataModel>> GetAllCarsAsync()
    {
        var cars = await this._usersService.GetAllCarsAsync();

        return cars;
    }

    public async Task<IEnumerable<MotorcyclesDataModel>> GetAllMotorcyclesAsync()
    {
        var motorcycles = await this._usersService.GetAllMotorcyclesAsync();
        return motorcycles;

    }

    public Task<IEnumerable<CarsDataModel>> GetMyCarsAsync(string adminId)
    {
        var myCars = this._usersService.GetMyCarsAsync(adminId);
        return myCars;
    }

    public Task<IEnumerable<MotorcyclesDataModel>> GetMyMotorcyclesAsync(string adminId)
    {
        var myMotorcycles = this._usersService.GetMyMotorcyclesASync(adminId);
        return myMotorcycles;
    }
}
