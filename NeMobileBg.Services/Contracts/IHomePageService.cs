using NeMobileBg.Common.Models.Home;

namespace NeMobileBg.Services.Contracts;

public interface IHomePageService
{
    Task<HomePageModel> GetHomePageVehicles();
}
