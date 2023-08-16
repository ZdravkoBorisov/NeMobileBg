namespace NeMobileBg.Web.Areas.Administrator.Services;

public class AdminService : IAdminService
{
    private readonly IUsersService _usersService;

    public AdminService(IUsersService usersService)
    {
        this._usersService = usersService;
    }

    public async Task<Result<IEnumerable<CarsDataModel>>> GetAllCarsAsync()
    {
        var result = await this._usersService.GetAllCarsAsync();
        if (result.Succeeded)
        {
            return result.Data.ToList();
        }

        return new List<CarsDataModel>();
    }

    public async Task<Result<IEnumerable<MotorcyclesDataModel>>> GetAllMotorcyclesAsync()
    {
        var result = await this._usersService.GetAllMotorcyclesAsync();
        if (result.Succeeded)
        {
            return result.Data.ToList();
        }

        return new List<MotorcyclesDataModel>();

    }

    public async Task<Result<IEnumerable<CarsDataModel>>> GetMyCarsAsync(string adminId)
    {
        var result = await this._usersService.GetMyCarsAsync(adminId);
        if (result.Succeeded)
        {
            return result.Data.ToList();
        }

        return new List<CarsDataModel>();
    }

    public async Task<Result<IEnumerable<MotorcyclesDataModel>>> GetMyMotorcyclesAsync(string adminId)
    {
        var result = await this._usersService.GetMyMotorcyclesASync(adminId);
        if (result.Succeeded)
        {
            return result.Data.ToList();
        }

        return new List<MotorcyclesDataModel>();
    }
}
