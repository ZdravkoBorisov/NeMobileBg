using NeMobileBg.Data.Models;

namespace NeMobileBg.Common.Models.Home;

public class HomePageModel
{
    public IEnumerable<Car> Cars { get; set; } = new List<Car>();

    public IEnumerable<Motorcycle> Motorcycles { get; set; } = new List<Motorcycle>();
}
