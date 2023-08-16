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

        if (cars != null)
        {
            result.Cars = cars;
        }

        if (motorcycles != null)
        {
            result.Motorcycles = motorcycles;
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
}
