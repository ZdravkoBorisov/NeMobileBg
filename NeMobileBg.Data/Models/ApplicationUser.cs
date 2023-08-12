
using Microsoft.AspNetCore.Identity;

namespace NeMobileBg.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() 
        {
            base.Id = Guid.NewGuid().ToString(); 
        }
        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string? Address { get; set; }

        public string City { get; set; } = default!;

        public IEnumerable<Car> Cars { get; set; } = new List<Car>();

        public IEnumerable<Truck> Trucks { get; set; } = new List<Truck>();

        public IEnumerable<Motorcycle> Motorcycles { get; set; } = new List<Motorcycle>();
    }
}
