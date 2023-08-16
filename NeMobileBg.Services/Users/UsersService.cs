namespace NeMobileBg.Services.Users;

public class UsersService : IUsersService
{
    private readonly IRepository _repository;

    public UsersService(IRepository repository)
    {
        this._repository = repository;
    }

    public async Task<Result<IEnumerable<CarsDataModel>>> GetMyCarsAsync(string userId)
    {
        try
        {
            var cars = await this._repository.GetAllAsync<Car>();
            if (cars == null)
            {
                return new List<CarsDataModel>();
            }

            var result = cars.Where(x => x.UserId == userId)
                             .Select(x => new CarsDataModel
                             {
                                 Id = x.Id,
                                 Make = x.Make,
                                 Model = x.Model,
                                 Description = x.Description,
                                 Price = x.Price,
                                 Year = x.Year,
                                 Category = x.Category,
                                 Gearbox = x.Gearbox,
                                 Color = x.Color,
                                 Condition = x.Condition,
                                 EuroStandard = x.EuroStandard,
                                 FuelType = x.FuelType,
                                 HorsePower = x.HorsePower,
                                 Mileage = x.Mileage,
                                 Convertible = x.Convertible,
                                 Doors = x.Doors,
                                 Seats = x.Seats,
                                 ImageUrl = x.ImageUrl,
                             }).ToList();

            return result;
        }
        catch (Exception ex)
        {
            return ex;
        }
    }

    public async Task<Result<IEnumerable<CarsDataModel>>> GetAllCarsAsync()
    {
        try
        {
            var cars = await this._repository.GetAllAsync<Car>();
            if (cars == null)
            {
                return new List<CarsDataModel>();
            }

            var result = cars.Select(x => new CarsDataModel
            {
                Id = x.Id,
                Make = x.Make,
                Model = x.Model,
                Description = x.Description,
                Price = x.Price,
                Year = x.Year,
                Category = x.Category,
                Gearbox = x.Gearbox,
                Color = x.Color,
                Condition = x.Condition,
                EuroStandard = x.EuroStandard,
                FuelType = x.FuelType,
                HorsePower = x.HorsePower,
                Mileage = x.Mileage,
                Convertible = x.Convertible,
                Doors = x.Doors,
                Seats = x.Seats,
                ImageUrl = x.ImageUrl,
                UserId = x.UserId,
            }).ToList();

            return result;
        }
        catch (Exception ex)
        {
            return ex;
        }
    }

    public async Task<Result<IEnumerable<MotorcyclesDataModel>>> GetMyMotorcyclesASync(string userId)
    {
        try
        {


            var motorcycles = await this._repository.GetAllAsync<Motorcycle>();
            if (motorcycles == null)
            {
                return new List<MotorcyclesDataModel>();
            }

            var result = motorcycles.Where(x => x.UserId == userId)
                                    .Select(x => new MotorcyclesDataModel
                                    {
                                        Id = x.Id,
                                        Make = x.Make,
                                        Model = x.Model,
                                        Description = x.Description,
                                        Price = x.Price,
                                        Year = x.Year,
                                        Category = x.Category,
                                        Color = x.Color,
                                        Condition = x.Condition,
                                        HorsePower = x.HorsePower,
                                        Mileage = x.Mileage,
                                        ImageUrl = x.ImageUrl,
                                    }).ToList();

            return result;
        }

        catch (Exception ex)
        {
            return ex;
        }
    }

    public async Task<Result<IEnumerable<MotorcyclesDataModel>>> GetAllMotorcyclesAsync()
    {
        try
        {


            var motorcycles = await this._repository.GetAllAsync<Motorcycle>();
            if (motorcycles == null)
            {
                return new List<MotorcyclesDataModel>();
            }
            var result = motorcycles.Select(x => new MotorcyclesDataModel
            {
                Id = x.Id,
                Make = x.Make,
                Model = x.Model,
                Description = x.Description,
                Price = x.Price,
                Year = x.Year,
                Category = x.Category,
                Color = x.Color,
                Condition = x.Condition,
                HorsePower = x.HorsePower,
                Mileage = x.Mileage,
                ImageUrl = x.ImageUrl,
                UserId = x.UserId,
            }).ToList();

            return result;
        }
        catch (Exception ex)
        {
            return ex;
        }
    }
}
