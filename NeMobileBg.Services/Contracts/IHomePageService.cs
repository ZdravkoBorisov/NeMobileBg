using NeMobileBg.Common.Home;

namespace NeMobileBg.Services.Contracts;

public interface IHomePageService
{
    Task<HomePageModel> GetHomePageVehicles();
}
