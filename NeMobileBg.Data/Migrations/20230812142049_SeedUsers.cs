using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeMobileBg.Data.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EuroStandart",
                table: "Trucks",
                newName: "EuroStandard");

            migrationBuilder.RenameColumn(
                name: "EuroStandart",
                table: "Motorcycles",
                newName: "EuroStandard");

            migrationBuilder.RenameColumn(
                name: "EuroStandart",
                table: "Cars",
                newName: "EuroStandard");

            migrationBuilder.AlterColumn<int>(
                name: "Axles",
                table: "Trucks",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "037f69eb-1390-435f-a085-e738fb60e93e", 0, null, "Sample City ", "86f4e27b-cef9-402c-b906-2760cce77e1c", "user@user.com", true, "Regular", "User ", false, null, null, null, "AQAAAAEAACcQAAAAEJ89u+CSXDAIUL/33Wx3ke1ybl+IWsBt9sUydoEqHu9Z8McqtcW6AIVOPP2szVCong==", null, false, "65a0f194-f98e-49e4-883c-54c53fa62a17", false, "user@user.com" },
                    { "296290bd-402b-4dc7-922f-3586f8d0c882", 0, null, "Sample City ", "920dd963-02a1-4396-8dba-d73bd80405ee", "user@user.com", true, "Regular", "User ", false, null, null, null, "AQAAAAEAACcQAAAAEG7TEcCahleb4S4XxyNwrkQz2MzumIs8lVAk/8XQpOzSgr/WTlRcDxUdwS0yDo0sMw==", null, false, "f3df6c15-8727-4864-84e5-ca02afda9b9c", false, "user@user.com" },
                    { "3035f543-8ce5-457d-8073-c086473cf18a", 0, null, "Sample City ", "af788763-726f-40c4-9e58-18dc94ff599e", "user@user.com", true, "Regular", "User ", false, null, null, null, "AQAAAAEAACcQAAAAEFxuAR21yTpITsZCfv6YxWVPCAIiRQElxm2jKgkmQdRpY0+4+e3nnHvoEKpvSnNY3A==", null, false, "22a16aea-725e-435c-8918-f055f22156c5", false, "user@user.com" },
                    { "40c03149-66ea-40bb-aa7e-7a21c50ad877", 0, null, "Sample City", "f9da97a0-bb9a-4f31-8509-893e710288da", "admin@admin.com", true, "Admin", "User", false, null, null, null, "AQAAAAEAACcQAAAAELx1ioUka3gc6DVVn/VdUwpfdoNhIe7z6+mA1NH+VYQphJ2kQ1IDSYhHm6kFBO4Wmw==", null, false, "e4080591-a521-4e82-92fa-2a0324f654c2", false, "admin@admin.com" },
                    { "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 0, null, "Sample City ", "359b9eaf-cd52-4dc8-b6c7-e255ffb4505b", "user@user.com", true, "Regular", "User ", false, null, null, null, "AQAAAAEAACcQAAAAELWB3rpd3o+cGhUkzSPiH/pjO6ZBU/Lw8HRhi2lKbJWpmbeLTEW0Us02NhFIlID9lw==", null, false, "39612fd1-2a92-4d34-bc39-f7a866c3228f", false, "user@user.com" },
                    { "5856091b-d323-445d-a07b-5c28db656393", 0, null, "Sample City ", "6eb4b2c3-1d16-411d-8da7-a63e3c141ccb", "user@user.com", true, "Regular", "User ", false, null, null, null, "AQAAAAEAACcQAAAAEIvMqXt/x7/BzG+Sv9ar6MvplSmfQJxnLdh6MhSXXhyHm/obTe6AR9XglVUt0whF+g==", null, false, "7052e02f-d516-4c59-adcd-cf56bd4dee73", false, "user@user.com" },
                    { "824856e7-f56b-4f18-807f-d75e04c81ed0", 0, null, "Sample City ", "1323796e-3195-48f6-93fe-17bd3b5a9b6b", "user@user.com", true, "Regular", "User ", false, null, null, null, "AQAAAAEAACcQAAAAEDewdZ0OLmcydzWtPqUnfecyO9Cz4qx0WBbYPdquTlc9LFNmKp0swRH4ZtFlZ/mSNQ==", null, false, "0543b14e-9db3-4917-a487-3b909600fbfb", false, "user@user.com" },
                    { "a3be7477-f92b-43b9-bf70-05c7a3c795f0", 0, null, "Sample City ", "5a739852-ac1f-45fe-af01-756317aa1bda", "user@user.com", true, "Regular", "User ", false, null, null, null, "AQAAAAEAACcQAAAAEOJ3MYclJoR1DQkiWellijORnbChJUfxwHTTPrw3dWKm/NfkHFkOQuRWN1OiNpCTBQ==", null, false, "32cfb4ca-94fc-4f1d-8276-4341a48bcc72", false, "user@user.com" },
                    { "cac28230-993c-449b-b723-ae38634028ab", 0, null, "Sample City ", "d3bb8dff-853e-4ab8-8839-f34d3cff15cd", "user@user.com", true, "Regular", "User ", false, null, null, null, "AQAAAAEAACcQAAAAEOuFX4mpDXHLAB5N8l1mBWObEJ3ZBqF6PG2IySEjn3gosmVzW8ZldPaEJYld8C5aqA==", null, false, "38fa900d-7196-441c-9ff4-e8f5b9e7f462", false, "user@user.com" },
                    { "e4154c9a-5aae-4ab5-8f22-f224880a3ba8", 0, null, "Sample City ", "67a5f7ba-e4e7-413a-9513-94c11ba39b3a", "user@user.com", true, "Regular", "User ", false, null, null, null, "AQAAAAEAACcQAAAAEMpNN/lfQSX+Le5NODE6Ec5vHgNlR9bhcLUvl3STIHstzqXr6HRl8m35p5kOIdF3bQ==", null, false, "b1b052ec-25f8-47f3-bcfb-84afddcbd0e1", false, "user@user.com" },
                    { "f5e77190-e257-4c89-b43e-4a136f02cb34", 0, null, "Sample City ", "45b108d0-51e2-4b23-a79b-02475d1b0ef5", "user@user.com", true, "Regular", "User ", false, null, null, null, "AQAAAAEAACcQAAAAEDMltgFG7oF90P9V7KxUecG917nj4zEyxruxJSdduxPMO9d/Bg5EOqmn/Yw4fuQhAQ==", null, false, "a48a5d0a-9871-4889-8504-0bb4c063d11c", false, "user@user.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "037f69eb-1390-435f-a085-e738fb60e93e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "296290bd-402b-4dc7-922f-3586f8d0c882");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3035f543-8ce5-457d-8073-c086473cf18a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40c03149-66ea-40bb-aa7e-7a21c50ad877");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5856091b-d323-445d-a07b-5c28db656393");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "824856e7-f56b-4f18-807f-d75e04c81ed0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3be7477-f92b-43b9-bf70-05c7a3c795f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac28230-993c-449b-b723-ae38634028ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4154c9a-5aae-4ab5-8f22-f224880a3ba8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5e77190-e257-4c89-b43e-4a136f02cb34");

            migrationBuilder.RenameColumn(
                name: "EuroStandard",
                table: "Trucks",
                newName: "EuroStandart");

            migrationBuilder.RenameColumn(
                name: "EuroStandard",
                table: "Motorcycles",
                newName: "EuroStandart");

            migrationBuilder.RenameColumn(
                name: "EuroStandard",
                table: "Cars",
                newName: "EuroStandart");

            migrationBuilder.AlterColumn<string>(
                name: "Axles",
                table: "Trucks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
