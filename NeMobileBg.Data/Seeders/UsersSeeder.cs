using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeMobileBg.Data.Models;

namespace NeMobileBg.Data.Seeders;

internal class UsersSeeder : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.HasData(this.SeedUsers());
    }
    public List<ApplicationUser> SeedUsers()
    {
        var result = new List<ApplicationUser>();
        var hasher = new PasswordHasher<ApplicationUser>();

        for (int i = 0; i < 10; i++)
        {
            var user = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = $"user@user.com",
                Email = $"user@user.com",
                PasswordHash = hasher.HashPassword(null, "123456"),
                FirstName = "Regular",
                LastName = $"User ",
                City = $"Sample City ",
                EmailConfirmed = true,
            };

            result.Add(user);
        }

        return result;
    }
}
