using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeMobileBg.Data.Migrations
{
    public partial class AddIdentityRolesUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f4bf6bac-19eb-40d0-afdd-10bc1c87b4c9", "037f69eb-1390-435f-a085-e738fb60e93e" },
                    { "f4bf6bac-19eb-40d0-afdd-10bc1c87b4c9", "296290bd-402b-4dc7-922f-3586f8d0c882" },
                    { "f4bf6bac-19eb-40d0-afdd-10bc1c87b4c9", "3035f543-8ce5-457d-8073-c086473cf18a" },
                    { "0c3fe04b-652f-4fdb-aa6d-a5fb6ce4c554", "40c03149-66ea-40bb-aa7e-7a21c50ad877" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4bf6bac-19eb-40d0-afdd-10bc1c87b4c9", "037f69eb-1390-435f-a085-e738fb60e93e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4bf6bac-19eb-40d0-afdd-10bc1c87b4c9", "296290bd-402b-4dc7-922f-3586f8d0c882" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4bf6bac-19eb-40d0-afdd-10bc1c87b4c9", "3035f543-8ce5-457d-8073-c086473cf18a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c3fe04b-652f-4fdb-aa6d-a5fb6ce4c554", "40c03149-66ea-40bb-aa7e-7a21c50ad877" });
        }
    }
}
