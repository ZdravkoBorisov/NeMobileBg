using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeMobileBg.Data.Migrations
{
    public partial class FixTyposAddCreatedOnVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedOn",
                table: "Trucks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedOn",
                table: "Motorcycles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedOn",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Category", "Color", "Condition", "Convertible", "CreatedOn", "Description", "Doors", "EuroStandard", "FuelType", "Gearbox", "HorsePower", "ImageUrl", "Make", "Mileage", "Model", "OwnerId", "Price", "Seats", "UserId", "Year" },
                values: new object[,]
                {
                    { "0259a114-1291-4c76-b097-8fbe5ab0b60e", "Estate", "Black", "Used", false, "7/21/2023 3:59:20 PM", "Description for Car 22", 4, "Euro 4", "Hybrid", "Manual", 122, null, "Brand22", 220000, "Model22", null, 220000m, 4, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2022 },
                    { "05f52fbc-ade9-497a-9e70-b3abb19af17a", "Estate", "Red", "Used", false, "8/9/2023 3:59:20 PM", "Description for Car 3", 4, "Euro 3", "Gasoline", "Manual", 103, null, "Brand3", 30000, "Model3", null, 30000m, 4, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2003 },
                    { "0d4d74d6-65fd-4a1b-924e-1e77e93d93da", "Estate", "Blue", "Used", false, "7/28/2023 3:59:20 PM", "Description for Car 15", 4, "Euro 3", "Gasoline", "Manual", 115, null, "Brand15", 150000, "Model15", null, 150000m, 4, "037f69eb-1390-435f-a085-e738fb60e93e", 2015 },
                    { "13eb7d0e-400d-44b4-a0af-22754f32e96e", "Estate", "Blue", "Used", false, "7/27/2023 3:59:20 PM", "Description for Car 16", 4, "Euro 4", "Diesel", "Automatic", 116, null, "Brand16", 160000, "Model16", null, 160000m, 4, "5856091b-d323-445d-a07b-5c28db656393", 2016 },
                    { "1738935d-6b7b-448c-96dc-08df7c21f9c9", "Estate", "Green", "Used", false, "7/29/2023 3:59:20 PM", "Description for Car 14", 4, "Euro 2", "Diesel", "Automatic", 114, null, "Brand14", 140000, "Model14", null, 140000m, 4, "5856091b-d323-445d-a07b-5c28db656393", 2014 },
                    { "2bd24005-4ce7-47cd-a446-9ebd0b7aa69e", "Estate", "Black", "Used", false, "7/30/2023 3:59:20 PM", "Description for Car 13", 4, "Euro 1", "Hybrid", "Manual", 113, null, "Brand13", 130000, "Model13", null, 130000m, 4, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2013 },
                    { "52dbcba9-770a-486f-8bca-06218bbc9757", "Estate", "Green", "Used", false, "8/8/2023 3:59:20 PM", "Description for Car 4", 4, "Euro 4", "Diesel", "Automatic", 104, null, "Brand4", 40000, "Model4", null, 40000m, 4, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2004 },
                    { "5a0a8bcc-da0f-41ec-b135-c7719434abff", "Estate", "Gray", "Used", false, "7/22/2023 3:59:20 PM", "Description for Car 21", 4, "Euro 3", "Electric", "Automatic", 121, null, "Brand21", 210000, "Model21", null, 210000m, 4, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2021 },
                    { "5c83639e-50c2-49fd-b670-eee711bee3e5", "Estate", "Black", "Used", false, "8/12/2023 3:59:20 PM", "Description for Car 0", 4, "Euro 0", "Electric", "Manual", 100, null, "Brand0", 0, "Model0", null, 0m, 4, "296290bd-402b-4dc7-922f-3586f8d0c882", 2000 },
                    { "61074e77-be88-4da6-acb0-54f4dfe92eab", "Estate", "Silver", "Used", false, "7/25/2023 3:59:20 PM", "Description for Car 18", 4, "Euro 0", "Diesel", "Automatic", 118, null, "Brand18", 180000, "Model18", null, 180000m, 4, "296290bd-402b-4dc7-922f-3586f8d0c882", 2018 },
                    { "668815fa-e6a9-4d48-952d-20e8d7a6743c", "Estate", "Silver", "Used", false, "7/31/2023 3:59:20 PM", "Description for Car 12", 4, "Euro 0", "Hybrid", "Automatic", 112, null, "Brand12", 120000, "Model12", null, 120000m, 4, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2012 },
                    { "6ee04301-f6a7-491e-9815-49c971f08dce", "Estate", "Black", "Used", false, "8/7/2023 3:59:20 PM", "Description for Car 5", 4, "Euro 5", "Electric", "Manual", 105, null, "Brand5", 50000, "Model5", null, 50000m, 4, "296290bd-402b-4dc7-922f-3586f8d0c882", 2005 },
                    { "8015685f-d931-4a10-bddc-5cc33ec4e74f", "Estate", "Red", "Used", false, "8/2/2023 3:59:20 PM", "Description for Car 10", 4, "Euro 4", "Electric", "Manual", 110, null, "Brand10", 100000, "Model10", null, 100000m, 4, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2010 },
                    { "83e06700-9de9-438c-b482-a079ea8d2c82", "Estate", "White", "Used", false, "7/26/2023 3:59:20 PM", "Description for Car 17", 4, "Euro 5", "Hybrid", "Automatic", 117, null, "Brand17", 170000, "Model17", null, 170000m, 4, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2017 },
                    { "92b7d51c-60ca-49e7-9ba9-d0bf92942a66", "Estate", "Blue", "Used", false, "8/3/2023 3:59:20 PM", "Description for Car 9", 4, "Euro 3", "Electric", "Automatic", 109, null, "Brand9", 90000, "Model9", null, 90000m, 4, "037f69eb-1390-435f-a085-e738fb60e93e", 2009 },
                    { "9f162f16-f5ff-41ad-b9ef-138a3ec57dd1", "Estate", "Red", "Used", false, "8/6/2023 3:59:20 PM", "Description for Car 6", 4, "Euro 0", "Diesel", "Automatic", 106, null, "Brand6", 60000, "Model6", null, 60000m, 4, "5856091b-d323-445d-a07b-5c28db656393", 2006 },
                    { "a01c0d18-25d3-4f65-91e6-b2b02c28b291", "Estate", "Blue", "Used", false, "7/24/2023 3:59:20 PM", "Description for Car 19", 4, "Euro 1", "Hybrid", "Manual", 119, null, "Brand19", 190000, "Model19", null, 190000m, 4, "037f69eb-1390-435f-a085-e738fb60e93e", 2019 },
                    { "a39e4148-f6bd-46d4-9779-0a557bb7bb55", "Estate", "Black", "Used", false, "8/11/2023 3:59:20 PM", "Description for Car 1", 4, "Euro 1", "Hybrid", "Manual", 101, null, "Brand1", 10000, "Model1", null, 10000m, 4, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2001 },
                    { "c0bdfab0-6921-47f8-9e1e-f9f46f4ce113", "Estate", "White", "Used", false, "8/10/2023 3:59:20 PM", "Description for Car 2", 4, "Euro 2", "Hybrid", "Manual", 102, null, "Brand2", 20000, "Model2", null, 20000m, 4, "3035f543-8ce5-457d-8073-c086473cf18a", 2002 },
                    { "c72128db-01d7-4e9f-9d16-18f1f8aa1c17", "Estate", "Black", "Used", false, "8/4/2023 3:59:20 PM", "Description for Car 8", 4, "Euro 2", "Hybrid", "Manual", 108, null, "Brand8", 80000, "Model8", null, 80000m, 4, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2008 },
                    { "ce6bc149-0a05-407d-8025-bba45d156a5c", "Estate", "Gray", "Used", false, "8/5/2023 3:59:20 PM", "Description for Car 7", 4, "Euro 1", "Gasoline", "Manual", 107, null, "Brand7", 70000, "Model7", null, 70000m, 4, "3035f543-8ce5-457d-8073-c086473cf18a", 2007 },
                    { "dc67d0c5-0768-47da-a11f-bc1e65e33133", "Estate", "Gray", "Used", false, "7/23/2023 3:59:20 PM", "Description for Car 20", 4, "Euro 2", "Hybrid", "Manual", 120, null, "Brand20", 200000, "Model20", null, 200000m, 4, "296290bd-402b-4dc7-922f-3586f8d0c882", 2020 },
                    { "f6e5c0be-47cc-46eb-8c3f-da5c9de3d5e3", "Estate", "Green", "Used", false, "8/1/2023 3:59:20 PM", "Description for Car 11", 4, "Euro 5", "Gasoline", "Automatic", 111, null, "Brand11", 110000, "Model11", null, 110000m, 4, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Motorcycles",
                columns: new[] { "Id", "Category", "Color", "Condition", "CreatedOn", "Description", "EuroStandard", "FuelType", "Gearbox", "HorsePower", "ImageUrl", "Make", "Mileage", "Model", "OwnerId", "Price", "RequiredLicense", "UserId", "Year" },
                values: new object[,]
                {
                    { "0111ee4b-6eed-48fb-8f92-45757f5e866f", "Sport", "Red", "Used", "7/23/2023 3:59:20 PM", "Description for Car 20", "Euro 2", "Diesel", "Manual", 120, null, "Brand20", 2000, "Model20", null, 200000m, null, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2020 },
                    { "0e5eb7e6-5dd9-45b3-82b2-7102fe862fad", "Sport", "Gray", "Used", "8/6/2023 3:59:20 PM", "Description for Car 6", "Euro 0", "Diesel", "Automatic", 106, null, "Brand6", 600, "Model6", null, 60000m, null, "296290bd-402b-4dc7-922f-3586f8d0c882", 2006 },
                    { "18eb55a0-61f5-4ce2-b609-429f0e35a4d2", "Sport", "Silver", "Used", "8/4/2023 3:59:20 PM", "Description for Car 8", "Euro 2", "Electric", "Manual", 108, null, "Brand8", 800, "Model8", null, 80000m, null, "5856091b-d323-445d-a07b-5c28db656393", 2008 },
                    { "49e57277-84ab-4103-aba9-f126ad59b74c", "Sport", "Blue", "Used", "7/24/2023 3:59:20 PM", "Description for Car 19", "Euro 1", "Hybrid", "Manual", 119, null, "Brand19", 1900, "Model19", null, 190000m, null, "3035f543-8ce5-457d-8073-c086473cf18a", 2019 },
                    { "50d31768-4944-4924-a37a-254dbbdf73e9", "Sport", "Blue", "Used", "8/7/2023 3:59:20 PM", "Description for Car 5", "Euro 5", "Diesel", "Manual", 105, null, "Brand5", 500, "Model5", null, 50000m, null, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2005 },
                    { "5334efa2-9a77-4a42-9794-ef623c4841e6", "Sport", "White", "Used", "7/31/2023 3:59:20 PM", "Description for Car 12", "Euro 0", "Diesel", "Automatic", 112, null, "Brand12", 1200, "Model12", null, 120000m, null, "296290bd-402b-4dc7-922f-3586f8d0c882", 2012 },
                    { "71b46df0-0e7e-4a98-a56a-ed2a080522db", "Sport", "Black", "Used", "8/11/2023 3:59:20 PM", "Description for Car 1", "Euro 1", "Hybrid", "Manual", 101, null, "Brand1", 100, "Model1", null, 10000m, null, "5856091b-d323-445d-a07b-5c28db656393", 2001 },
                    { "7e52f5fd-480a-4543-bc14-e8279d76b56e", "Sport", "Silver", "Used", "7/29/2023 3:59:20 PM", "Description for Car 14", "Euro 2", "Hybrid", "Automatic", 114, null, "Brand14", 1400, "Model14", null, 140000m, null, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2014 },
                    { "84fd9920-583d-4511-a050-c9818d37ecb5", "Sport", "Green", "Used", "8/1/2023 3:59:20 PM", "Description for Car 11", "Euro 5", "Hybrid", "Automatic", 111, null, "Brand11", 1100, "Model11", null, 110000m, null, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2011 },
                    { "89098372-7ca4-41ff-b611-4cded9d86b08", "Sport", "Red", "Used", "7/26/2023 3:59:20 PM", "Description for Car 17", "Euro 5", "Diesel", "Manual", 117, null, "Brand17", 1700, "Model17", null, 170000m, null, "296290bd-402b-4dc7-922f-3586f8d0c882", 2017 },
                    { "8a599716-d306-4fa0-847c-56c31df2aada", "Sport", "White", "Used", "8/3/2023 3:59:20 PM", "Description for Car 9", "Euro 3", "Diesel", "Manual", 109, null, "Brand9", 900, "Model9", null, 90000m, null, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2009 },
                    { "92e1d435-e7ca-4dbf-866f-4a2dd75dc490", "Sport", "Gray", "Used", "7/27/2023 3:59:20 PM", "Description for Car 16", "Euro 4", "Diesel", "Automatic", 116, null, "Brand16", 1600, "Model16", null, 160000m, null, "296290bd-402b-4dc7-922f-3586f8d0c882", 2016 },
                    { "989bf659-88df-4741-9aee-5aca3aeef20f", "Sport", "Blue", "Used", "7/22/2023 3:59:20 PM", "Description for Car 21", "Euro 3", "Gasoline", "Automatic", 121, null, "Brand21", 2100, "Model21", null, 210000m, null, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2021 },
                    { "ae03b05a-b2db-4ce2-ab69-e7400f61883d", "Sport", "Silver", "Used", "7/25/2023 3:59:20 PM", "Description for Car 18", "Euro 0", "Electric", "Automatic", 118, null, "Brand18", 1800, "Model18", null, 180000m, null, "3035f543-8ce5-457d-8073-c086473cf18a", 2018 },
                    { "aed8bf9f-300d-4f14-9be5-779378179d42", "Sport", "Black", "Used", "7/28/2023 3:59:20 PM", "Description for Car 15", "Euro 3", "Diesel", "Manual", 115, null, "Brand15", 1500, "Model15", null, 150000m, null, "5856091b-d323-445d-a07b-5c28db656393", 2015 },
                    { "baa01e18-aba5-43e9-a33e-86604ddfcfce", "Sport", "Gray", "Used", "8/9/2023 3:59:20 PM", "Description for Car 3", "Euro 3", "Electric", "Automatic", 103, null, "Brand3", 300, "Model3", null, 30000m, null, "3035f543-8ce5-457d-8073-c086473cf18a", 2003 },
                    { "c21094e2-1992-4d21-8ac9-17555424627a", "Sport", "Black", "Used", "8/12/2023 3:59:20 PM", "Description for Car 0", "Euro 0", "Diesel", "Manual", 100, null, "Brand0", 0, "Model0", null, 0m, null, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2000 },
                    { "d92e687d-8346-4204-ac42-9cf56206b674", "Sport", "Black", "Used", "8/8/2023 3:59:20 PM", "Description for Car 4", "Euro 4", "Diesel", "Manual", 104, null, "Brand4", 400, "Model4", null, 40000m, null, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2004 },
                    { "daa643cf-fa51-4eca-be5b-cd67e59be3f7", "Sport", "Gray", "Used", "8/10/2023 3:59:20 PM", "Description for Car 2", "Euro 2", "Diesel", "Manual", 102, null, "Brand2", 200, "Model2", null, 20000m, null, "037f69eb-1390-435f-a085-e738fb60e93e", 2002 }
                });

            migrationBuilder.InsertData(
                table: "Motorcycles",
                columns: new[] { "Id", "Category", "Color", "Condition", "CreatedOn", "Description", "EuroStandard", "FuelType", "Gearbox", "HorsePower", "ImageUrl", "Make", "Mileage", "Model", "OwnerId", "Price", "RequiredLicense", "UserId", "Year" },
                values: new object[,]
                {
                    { "ee61cd07-b4a9-4a2b-9799-7ab6d87db37d", "Sport", "Blue", "Used", "8/2/2023 3:59:20 PM", "Description for Car 10", "Euro 4", "Gasoline", "Automatic", 110, null, "Brand10", 1000, "Model10", null, 100000m, null, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2010 },
                    { "f458dd55-de40-4f83-a8b1-e04d2b7dbed0", "Sport", "Red", "Used", "7/21/2023 3:59:20 PM", "Description for Car 22", "Euro 4", "Hybrid", "Automatic", 122, null, "Brand22", 2200, "Model22", null, 220000m, null, "037f69eb-1390-435f-a085-e738fb60e93e", 2022 },
                    { "fa0942f6-e945-4c3d-9661-cd50ccfc9150", "Sport", "Green", "Used", "8/5/2023 3:59:20 PM", "Description for Car 7", "Euro 1", "Gasoline", "Automatic", 107, null, "Brand7", 700, "Model7", null, 70000m, null, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2007 },
                    { "ff999e2f-d5f2-475a-bbf2-290e87b26f7b", "Sport", "Blue", "Used", "7/30/2023 3:59:20 PM", "Description for Car 13", "Euro 1", "Hybrid", "Manual", 113, null, "Brand13", 1300, "Model13", null, 130000m, null, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2013 }
                });

            migrationBuilder.InsertData(
                table: "Trucks",
                columns: new[] { "Id", "Axles", "Color", "Condition", "CreatedOn", "Description", "EuroStandard", "FuelType", "Gearbox", "HorsePower", "ImageUrl", "Make", "Mileage", "Model", "OwnerId", "Price", "UserId", "Year" },
                values: new object[,]
                {
                    { "0069bbc0-3322-4f36-9fc0-87d989230640", 8, "Gray", "Used", "7/25/2023 3:59:20 PM", "Description for Car 18", "Euro 0", "Diesel", "Automatic", 118, null, "Brand18", 1800, "Model18", null, 180000m, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2018 },
                    { "05688b4c-8469-4cf7-b3e4-81cb04b99d6f", 8, "Black", "Used", "8/6/2023 3:59:20 PM", "Description for Car 6", "Euro 0", "Hybrid", "Manual", 106, null, "Brand6", 600, "Model6", null, 60000m, "296290bd-402b-4dc7-922f-3586f8d0c882", 2006 },
                    { "1baa69af-11ab-43e7-bbe9-9b358c193bf8", 8, "Black", "Used", "8/2/2023 3:59:20 PM", "Description for Car 10", "Euro 4", "Hybrid", "Automatic", 110, null, "Brand10", 1000, "Model10", null, 100000m, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2010 },
                    { "2b261127-ec99-45ec-835e-b8dd8950490f", 8, "Green", "Used", "7/23/2023 3:59:20 PM", "Description for Car 20", "Euro 2", "Diesel", "Manual", 120, null, "Brand20", 2000, "Model20", null, 200000m, "037f69eb-1390-435f-a085-e738fb60e93e", 2020 },
                    { "445e5797-6ade-48b2-8f16-b38f4f0dab75", 8, "Blue", "Used", "8/5/2023 3:59:20 PM", "Description for Car 7", "Euro 1", "Diesel", "Automatic", 107, null, "Brand7", 700, "Model7", null, 70000m, "3035f543-8ce5-457d-8073-c086473cf18a", 2007 },
                    { "58f51f62-6f58-471d-94c2-550f4e7e8c0b", 8, "Silver", "Used", "7/21/2023 3:59:20 PM", "Description for Car 22", "Euro 4", "Electric", "Manual", 122, null, "Brand22", 2200, "Model22", null, 220000m, "037f69eb-1390-435f-a085-e738fb60e93e", 2022 },
                    { "5b520003-8b97-4d5d-907b-aa12ee569588", 8, "Green", "Used", "8/9/2023 3:59:20 PM", "Description for Car 3", "Euro 3", "Electric", "Automatic", 103, null, "Brand3", 300, "Model3", null, 30000m, "5856091b-d323-445d-a07b-5c28db656393", 2003 },
                    { "684558e1-8dee-4929-b84b-60e6ec67c92a", 8, "Black", "Used", "8/12/2023 3:59:20 PM", "Description for Car 0", "Euro 0", "Electric", "Manual", 100, null, "Brand0", 0, "Model0", null, 0m, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2000 },
                    { "70f25f78-f9a2-4bbf-a65b-acd423b5dde0", 8, "White", "Used", "8/11/2023 3:59:20 PM", "Description for Car 1", "Euro 1", "Diesel", "Manual", 101, null, "Brand1", 100, "Model1", null, 10000m, "5856091b-d323-445d-a07b-5c28db656393", 2001 },
                    { "780357b7-9609-43c9-b7ec-27b17d4f18d2", 8, "White", "Used", "7/28/2023 3:59:20 PM", "Description for Car 15", "Euro 3", "Gasoline", "Manual", 115, null, "Brand15", 1500, "Model15", null, 150000m, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2015 },
                    { "834c9bb8-0e2f-4fd3-bd0b-57a1df70c190", 8, "Gray", "Used", "7/26/2023 3:59:20 PM", "Description for Car 17", "Euro 5", "Hybrid", "Manual", 117, null, "Brand17", 1700, "Model17", null, 170000m, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2017 },
                    { "a242fd1f-b6d6-432a-a90f-211c6373b926", 8, "Gray", "Used", "8/7/2023 3:59:20 PM", "Description for Car 5", "Euro 5", "Diesel", "Automatic", 105, null, "Brand5", 500, "Model5", null, 50000m, "296290bd-402b-4dc7-922f-3586f8d0c882", 2005 },
                    { "c5685f95-02b9-43aa-9c05-9563213d5dba", 8, "Silver", "Used", "7/31/2023 3:59:20 PM", "Description for Car 12", "Euro 0", "Electric", "Manual", 112, null, "Brand12", 1200, "Model12", null, 120000m, "037f69eb-1390-435f-a085-e738fb60e93e", 2012 },
                    { "cb03141e-2209-4e3a-b874-520202048a31", 8, "Green", "Used", "8/1/2023 3:59:20 PM", "Description for Car 11", "Euro 5", "Gasoline", "Manual", 111, null, "Brand11", 1100, "Model11", null, 110000m, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2011 },
                    { "cb4a974d-e639-46b4-a3dd-acd9c82567af", 8, "Silver", "Used", "7/24/2023 3:59:20 PM", "Description for Car 19", "Euro 1", "Hybrid", "Automatic", 119, null, "Brand19", 1900, "Model19", null, 190000m, "5856091b-d323-445d-a07b-5c28db656393", 2019 },
                    { "d8250942-12b1-45fd-96ae-53734e57fed1", 8, "White", "Used", "7/30/2023 3:59:20 PM", "Description for Car 13", "Euro 1", "Hybrid", "Manual", 113, null, "Brand13", 1300, "Model13", null, 130000m, "037f69eb-1390-435f-a085-e738fb60e93e", 2013 },
                    { "def990a6-66e7-49a6-8176-015e75a30fc7", 8, "Gray", "Used", "7/22/2023 3:59:20 PM", "Description for Car 21", "Euro 3", "Hybrid", "Manual", 121, null, "Brand21", 2100, "Model21", null, 210000m, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2021 },
                    { "e06ae97a-731d-4e26-88ef-dda94002927a", 8, "Gray", "Used", "8/4/2023 3:59:20 PM", "Description for Car 8", "Euro 2", "Hybrid", "Automatic", 108, null, "Brand8", 800, "Model8", null, 80000m, "5856091b-d323-445d-a07b-5c28db656393", 2008 },
                    { "e60bb9de-8d04-46d4-b4d8-f312d62473a9", 8, "Green", "Used", "8/8/2023 3:59:20 PM", "Description for Car 4", "Euro 4", "Diesel", "Automatic", 104, null, "Brand4", 400, "Model4", null, 40000m, "296290bd-402b-4dc7-922f-3586f8d0c882", 2004 },
                    { "ed4967d3-02cf-4499-baa5-3f6f9e7a722e", 8, "Gray", "Used", "8/3/2023 3:59:20 PM", "Description for Car 9", "Euro 3", "Electric", "Automatic", 109, null, "Brand9", 900, "Model9", null, 90000m, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2009 },
                    { "f001b0c3-c814-4be1-8892-b791d882e48a", 8, "White", "Used", "8/10/2023 3:59:20 PM", "Description for Car 2", "Euro 2", "Diesel", "Automatic", 102, null, "Brand2", 200, "Model2", null, 20000m, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2002 },
                    { "f3a3918a-ffc6-42ab-80b7-f4dfb74f5d96", 8, "Black", "Used", "7/27/2023 3:59:20 PM", "Description for Car 16", "Euro 4", "Gasoline", "Manual", 116, null, "Brand16", 1600, "Model16", null, 160000m, "296290bd-402b-4dc7-922f-3586f8d0c882", 2016 },
                    { "f8fb21c6-1e75-40e3-91f7-61834d208118", 8, "Red", "Used", "7/29/2023 3:59:20 PM", "Description for Car 14", "Euro 2", "Gasoline", "Manual", 114, null, "Brand14", 1400, "Model14", null, 140000m, "037f69eb-1390-435f-a085-e738fb60e93e", 2014 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "0259a114-1291-4c76-b097-8fbe5ab0b60e");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "05f52fbc-ade9-497a-9e70-b3abb19af17a");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "0d4d74d6-65fd-4a1b-924e-1e77e93d93da");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "13eb7d0e-400d-44b4-a0af-22754f32e96e");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "1738935d-6b7b-448c-96dc-08df7c21f9c9");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "2bd24005-4ce7-47cd-a446-9ebd0b7aa69e");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "52dbcba9-770a-486f-8bca-06218bbc9757");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "5a0a8bcc-da0f-41ec-b135-c7719434abff");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "5c83639e-50c2-49fd-b670-eee711bee3e5");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "61074e77-be88-4da6-acb0-54f4dfe92eab");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "668815fa-e6a9-4d48-952d-20e8d7a6743c");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "6ee04301-f6a7-491e-9815-49c971f08dce");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "8015685f-d931-4a10-bddc-5cc33ec4e74f");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "83e06700-9de9-438c-b482-a079ea8d2c82");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "92b7d51c-60ca-49e7-9ba9-d0bf92942a66");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "9f162f16-f5ff-41ad-b9ef-138a3ec57dd1");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "a01c0d18-25d3-4f65-91e6-b2b02c28b291");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "a39e4148-f6bd-46d4-9779-0a557bb7bb55");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "c0bdfab0-6921-47f8-9e1e-f9f46f4ce113");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "c72128db-01d7-4e9f-9d16-18f1f8aa1c17");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "ce6bc149-0a05-407d-8025-bba45d156a5c");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "dc67d0c5-0768-47da-a11f-bc1e65e33133");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "f6e5c0be-47cc-46eb-8c3f-da5c9de3d5e3");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "0111ee4b-6eed-48fb-8f92-45757f5e866f");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "0e5eb7e6-5dd9-45b3-82b2-7102fe862fad");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "18eb55a0-61f5-4ce2-b609-429f0e35a4d2");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "49e57277-84ab-4103-aba9-f126ad59b74c");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "50d31768-4944-4924-a37a-254dbbdf73e9");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "5334efa2-9a77-4a42-9794-ef623c4841e6");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "71b46df0-0e7e-4a98-a56a-ed2a080522db");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "7e52f5fd-480a-4543-bc14-e8279d76b56e");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "84fd9920-583d-4511-a050-c9818d37ecb5");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "89098372-7ca4-41ff-b611-4cded9d86b08");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "8a599716-d306-4fa0-847c-56c31df2aada");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "92e1d435-e7ca-4dbf-866f-4a2dd75dc490");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "989bf659-88df-4741-9aee-5aca3aeef20f");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "ae03b05a-b2db-4ce2-ab69-e7400f61883d");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "aed8bf9f-300d-4f14-9be5-779378179d42");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "baa01e18-aba5-43e9-a33e-86604ddfcfce");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "c21094e2-1992-4d21-8ac9-17555424627a");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "d92e687d-8346-4204-ac42-9cf56206b674");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "daa643cf-fa51-4eca-be5b-cd67e59be3f7");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "ee61cd07-b4a9-4a2b-9799-7ab6d87db37d");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "f458dd55-de40-4f83-a8b1-e04d2b7dbed0");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "fa0942f6-e945-4c3d-9661-cd50ccfc9150");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "ff999e2f-d5f2-475a-bbf2-290e87b26f7b");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "0069bbc0-3322-4f36-9fc0-87d989230640");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "05688b4c-8469-4cf7-b3e4-81cb04b99d6f");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "1baa69af-11ab-43e7-bbe9-9b358c193bf8");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "2b261127-ec99-45ec-835e-b8dd8950490f");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "445e5797-6ade-48b2-8f16-b38f4f0dab75");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "58f51f62-6f58-471d-94c2-550f4e7e8c0b");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "5b520003-8b97-4d5d-907b-aa12ee569588");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "684558e1-8dee-4929-b84b-60e6ec67c92a");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "70f25f78-f9a2-4bbf-a65b-acd423b5dde0");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "780357b7-9609-43c9-b7ec-27b17d4f18d2");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "834c9bb8-0e2f-4fd3-bd0b-57a1df70c190");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "a242fd1f-b6d6-432a-a90f-211c6373b926");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "c5685f95-02b9-43aa-9c05-9563213d5dba");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "cb03141e-2209-4e3a-b874-520202048a31");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "cb4a974d-e639-46b4-a3dd-acd9c82567af");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "d8250942-12b1-45fd-96ae-53734e57fed1");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "def990a6-66e7-49a6-8176-015e75a30fc7");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "e06ae97a-731d-4e26-88ef-dda94002927a");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "e60bb9de-8d04-46d4-b4d8-f312d62473a9");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "ed4967d3-02cf-4499-baa5-3f6f9e7a722e");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "f001b0c3-c814-4be1-8892-b791d882e48a");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "f3a3918a-ffc6-42ab-80b7-f4dfb74f5d96");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "f8fb21c6-1e75-40e3-91f7-61834d208118");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Motorcycles");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Cars");
        }
    }
}
