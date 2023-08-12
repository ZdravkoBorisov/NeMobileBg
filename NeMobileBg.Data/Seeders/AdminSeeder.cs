using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NeMobileBg.Data.Seeders;

internal class RolesSeeder : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(this.SeedRoles());
    }

    private List<IdentityRole> SeedRoles()
    {
        var result = new List<IdentityRole>();

        var adminRole = new IdentityRole
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Administrator",
            NormalizedName = "ADMINISTRATOR",
            ConcurrencyStamp = Guid.NewGuid().ToString(),
        };

        var userRole = new IdentityRole
        {
            Id = Guid.NewGuid().ToString(),
            Name = "User",
            NormalizedName = "USER",
            ConcurrencyStamp = Guid.NewGuid().ToString(),
        };

        result.Add(adminRole);
        result.Add(userRole);

        return result;

    }
}
