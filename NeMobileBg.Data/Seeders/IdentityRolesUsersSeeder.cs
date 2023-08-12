using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NeMobileBg.Data.Seeders;

internal class IdentityRolesUsersSeeder : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(this.GenerateUsersRoles());
    }

    private List<IdentityUserRole<string>> GenerateUsersRoles()
    {

        var result = new List<IdentityUserRole<string>>();

        var adminRole = new IdentityUserRole<string>
        {
            RoleId = "0c3fe04b-652f-4fdb-aa6d-a5fb6ce4c554",
            UserId = "40c03149-66ea-40bb-aa7e-7a21c50ad877",
        };
        result.Add(adminRole);

        var userRole = new IdentityUserRole<string>
        {
            RoleId = "f4bf6bac-19eb-40d0-afdd-10bc1c87b4c9",
            UserId = "3035f543-8ce5-457d-8073-c086473cf18a",
        };
        result.Add(userRole);

        userRole = new IdentityUserRole<string>
        {
            RoleId = "f4bf6bac-19eb-40d0-afdd-10bc1c87b4c9",
            UserId = "296290bd-402b-4dc7-922f-3586f8d0c882",
        };

        result.Add(userRole);
        userRole = new IdentityUserRole<string>
        {
            RoleId = "f4bf6bac-19eb-40d0-afdd-10bc1c87b4c9",
            UserId = "037f69eb-1390-435f-a085-e738fb60e93e",
        };
        result.Add(userRole);

        return result;

    }
}
