using NeMobileBg.Common.Models.Home;
using NeMobileBg.Data.Models;
using NeMobileBg.Data.Repository;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Services;

public class HomePageService : IHomePageService
{
    private readonly IRepository _repository;

    public HomePageService(IRepository repository)
    {
        this._repository = repository;
    }

    public async Task<HomePageModel> GetHomePageVehicles()
    {
        var result = new HomePageModel();

        var cars = await this.GetHomePageCars();
        var motorcycles = await this.GetHomePageMotorcycles();
        var trucks = await this.GetHomePageTrucks();

        if (cars != null)
        {
            result.Cars = cars;
        }

        if (motorcycles != null)
        {
            result.Motorcycles = motorcycles;
        }

        if (trucks != null)
        {
            result.Trucks = trucks;
        }

        return result;
    }

    private async Task<IEnumerable<Car>> GetHomePageCars()
    {
        var cars = await this._repository.GetLastCreatedAsync<Car>(car => car.CreatedOn, count: 8);
        return cars;
    }

    private async Task<IEnumerable<Motorcycle>> GetHomePageMotorcycles()
    {
        var motorcycles = await this._repository.GetLastCreatedAsync<Motorcycle>(motorcycle => motorcycle.CreatedOn, count: 8);
        return motorcycles;
    }

    private async Task<IEnumerable<Truck>> GetHomePageTrucks()
    {
        var trucks = await this._repository.GetLastCreatedAsync<Truck>(truck => truck.CreatedOn, count: 8);
        return trucks;
    }
}
