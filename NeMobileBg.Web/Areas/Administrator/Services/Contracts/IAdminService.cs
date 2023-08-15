﻿using NeMobileBg.Common;
using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Common.Models.Motorcycles;

namespace NeMobileBg.Web.Areas.Administrator.Services.Contracts;

public interface IAdminService
{
    Task<Result<IEnumerable<CarsDataModel>>> GetMyCarsAsync(string adminId);
    Task<Result<IEnumerable<CarsDataModel>>> GetAllCarsAsync();
    Task<Result<IEnumerable<MotorcyclesDataModel>>> GetMyMotorcyclesAsync(string adminId);
    Task<Result<IEnumerable<MotorcyclesDataModel>>> GetAllMotorcyclesAsync();

}
