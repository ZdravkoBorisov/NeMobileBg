using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeMobileBg.Data.Migrations
{
    public partial class SeedVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "ImageUrl",
                table: "Trucks",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ImageUrl",
                table: "Motorcycles",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ImageUrl",
                table: "Cars",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Category", "Color", "Condition", "Convertible", "Description", "Doors", "EuroStandard", "FuelType", "Gearbox", "HorsePower", "ImageUrl", "Make", "Mileage", "Model", "OwnerId", "Price", "Seats", "UserId", "Year" },
                values: new object[,]
                {
                    { "0118d801-3738-4c18-a1a7-8365cfaf1115", "Estate", "Silver", "Used", false, "Description for Car 6", 4, "Euro 0", "Gasoline", "Manual", 106, null, "Brand6", 60000, "Model6", null, 60000m, 4, "5856091b-d323-445d-a07b-5c28db656393", 2006 },
                    { "1a37253e-f728-40de-9cc1-eece0c226851", "Estate", "Blue", "Used", false, "Description for Car 10", 4, "Euro 4", "Electric", "Automatic", 110, null, "Brand10", 100000, "Model10", null, 100000m, 4, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2010 },
                    { "27e6fde3-c98d-49c8-b90b-948a0aa48fba", "Estate", "Red", "Used", false, "Description for Car 11", 4, "Euro 5", "Diesel", "Automatic", 111, null, "Brand11", 110000, "Model11", null, 110000m, 4, "3035f543-8ce5-457d-8073-c086473cf18a", 2011 },
                    { "2c0055dd-8ff0-428d-b8c4-e36c39881706", "Estate", "Blue", "Used", false, "Description for Car 14", 4, "Euro 2", "Diesel", "Automatic", 114, null, "Brand14", 140000, "Model14", null, 140000m, 4, "3035f543-8ce5-457d-8073-c086473cf18a", 2014 },
                    { "32da0e58-929a-4f5d-b096-e8b7d6a9ca69", "Estate", "White", "Used", false, "Description for Car 4", 4, "Euro 4", "Electric", "Automatic", 104, null, "Brand4", 40000, "Model4", null, 40000m, 4, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2004 },
                    { "3cc7b998-f044-4b59-a736-da8c35216146", "Estate", "Blue", "Used", false, "Description for Car 8", 4, "Euro 2", "Hybrid", "Automatic", 108, null, "Brand8", 80000, "Model8", null, 80000m, 4, "3035f543-8ce5-457d-8073-c086473cf18a", 2008 },
                    { "4f5fa115-869c-4407-aca0-3c8219369c91", "Estate", "Gray", "Used", false, "Description for Car 13", 4, "Euro 1", "Diesel", "Manual", 113, null, "Brand13", 130000, "Model13", null, 130000m, 4, "296290bd-402b-4dc7-922f-3586f8d0c882", 2013 },
                    { "62d176a7-679b-4adf-9b71-6b05a65acb43", "Estate", "Silver", "Used", false, "Description for Car 19", 4, "Euro 1", "Diesel", "Manual", 119, null, "Brand19", 190000, "Model19", null, 190000m, 4, "5856091b-d323-445d-a07b-5c28db656393", 2019 },
                    { "65c247c4-4090-4e5b-9e3f-41c0a6bcaf89", "Estate", "White", "Used", false, "Description for Car 7", 4, "Euro 1", "Hybrid", "Automatic", 107, null, "Brand7", 70000, "Model7", null, 70000m, 4, "037f69eb-1390-435f-a085-e738fb60e93e", 2007 },
                    { "746766a5-e688-4f3d-ba3d-343a663e0504", "Estate", "Silver", "Used", false, "Description for Car 16", 4, "Euro 4", "Hybrid", "Manual", 116, null, "Brand16", 160000, "Model16", null, 160000m, 4, "296290bd-402b-4dc7-922f-3586f8d0c882", 2016 },
                    { "807bc866-6919-4fef-9ce9-9e9247c998c1", "Estate", "Black", "Used", false, "Description for Car 9", 4, "Euro 3", "Gasoline", "Manual", 109, null, "Brand9", 90000, "Model9", null, 90000m, 4, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2009 },
                    { "86c4a8d7-cbcf-4b07-adce-2537bf52aa58", "Estate", "White", "Used", false, "Description for Car 2", 4, "Euro 2", "Hybrid", "Automatic", 102, null, "Brand2", 20000, "Model2", null, 20000m, 4, "037f69eb-1390-435f-a085-e738fb60e93e", 2002 },
                    { "871f8c4a-8af1-4c84-b05a-cd4a2cc0e2e0", "Estate", "Gray", "Used", false, "Description for Car 1", 4, "Euro 1", "Diesel", "Automatic", 101, null, "Brand1", 10000, "Model1", null, 10000m, 4, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2001 },
                    { "8951e288-74ac-4064-bfb9-8b02225237f3", "Estate", "Green", "Used", false, "Description for Car 3", 4, "Euro 3", "Hybrid", "Manual", 103, null, "Brand3", 30000, "Model3", null, 30000m, 4, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2003 },
                    { "98d59966-147f-4e7c-ae59-272c094f1a42", "Estate", "Blue", "Used", false, "Description for Car 21", 4, "Euro 3", "Diesel", "Automatic", 121, null, "Brand21", 210000, "Model21", null, 210000m, 4, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2021 },
                    { "99b23c21-be04-4dbe-a26b-fe479b9565c5", "Estate", "White", "Used", false, "Description for Car 5", 4, "Euro 5", "Electric", "Automatic", 105, null, "Brand5", 50000, "Model5", null, 50000m, 4, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2005 },
                    { "a059ae35-beea-4525-886a-d67205ca7752", "Estate", "Green", "Used", false, "Description for Car 12", 4, "Euro 0", "Gasoline", "Manual", 112, null, "Brand12", 120000, "Model12", null, 120000m, 4, "3035f543-8ce5-457d-8073-c086473cf18a", 2012 },
                    { "a0ce2b3d-4dc4-4186-9e8f-35099bd13ae9", "Estate", "Green", "Used", false, "Description for Car 20", 4, "Euro 2", "Electric", "Manual", 120, null, "Brand20", 200000, "Model20", null, 200000m, 4, "037f69eb-1390-435f-a085-e738fb60e93e", 2020 },
                    { "a2074234-22aa-4a53-b3e8-1e16a16d5bbe", "Estate", "Black", "Used", false, "Description for Car 17", 4, "Euro 5", "Gasoline", "Automatic", 117, null, "Brand17", 170000, "Model17", null, 170000m, 4, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2017 },
                    { "c6a9da32-950d-4398-8d21-ef1fd62af989", "Estate", "Silver", "Used", false, "Description for Car 22", 4, "Euro 4", "Gasoline", "Manual", 122, null, "Brand22", 220000, "Model22", null, 220000m, 4, "5856091b-d323-445d-a07b-5c28db656393", 2022 },
                    { "e45c88c3-c033-422c-869d-dd8840942aeb", "Estate", "Blue", "Used", false, "Description for Car 0", 4, "Euro 0", "Diesel", "Manual", 100, null, "Brand0", 0, "Model0", null, 0m, 4, "296290bd-402b-4dc7-922f-3586f8d0c882", 2000 },
                    { "f5c9d9ce-4fbb-462d-b706-0eec7edba8dc", "Estate", "Red", "Used", false, "Description for Car 18", 4, "Euro 0", "Gasoline", "Automatic", 118, null, "Brand18", 180000, "Model18", null, 180000m, 4, "5856091b-d323-445d-a07b-5c28db656393", 2018 },
                    { "f8a757ad-043e-48a9-8b12-f681104b2602", "Estate", "Red", "Used", false, "Description for Car 15", 4, "Euro 3", "Gasoline", "Automatic", 115, null, "Brand15", 150000, "Model15", null, 150000m, 4, "3035f543-8ce5-457d-8073-c086473cf18a", 2015 }
                });

            migrationBuilder.InsertData(
                table: "Motorcycles",
                columns: new[] { "Id", "Category", "Color", "Condition", "Description", "EuroStandard", "FuelType", "Gearbox", "HorsePower", "ImageUrl", "Make", "Mileage", "Model", "OwnerId", "Price", "RequiredLicense", "UserId", "Year" },
                values: new object[,]
                {
                    { "00f49ed2-1598-433f-a9f8-d559bae0b89a", "Sport", "Green", "Used", "Description for Car 5", "Euro 5", "Hybrid", "Automatic", 105, null, "Brand5", 500, "Model5", null, 50000m, null, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2005 },
                    { "21ad2539-b955-4470-ac81-ebf764f0d580", "Sport", "Black", "Used", "Description for Car 2", "Euro 2", "Electric", "Automatic", 102, null, "Brand2", 200, "Model2", null, 20000m, null, "296290bd-402b-4dc7-922f-3586f8d0c882", 2002 },
                    { "22447127-94b0-412a-8b43-c9ad8f3a6894", "Sport", "Gray", "Used", "Description for Car 15", "Euro 3", "Gasoline", "Automatic", 115, null, "Brand15", 1500, "Model15", null, 150000m, null, "037f69eb-1390-435f-a085-e738fb60e93e", 2015 },
                    { "26399eea-229c-446d-9468-06fe6b9d008b", "Sport", "Green", "Used", "Description for Car 9", "Euro 3", "Diesel", "Automatic", 109, null, "Brand9", 900, "Model9", null, 90000m, null, "037f69eb-1390-435f-a085-e738fb60e93e", 2009 },
                    { "335ab57c-270f-4e9a-b470-4e1834660d28", "Sport", "Green", "Used", "Description for Car 16", "Euro 4", "Diesel", "Manual", 116, null, "Brand16", 1600, "Model16", null, 160000m, null, "037f69eb-1390-435f-a085-e738fb60e93e", 2016 },
                    { "35c0f1f3-32b5-404f-b39d-8b31d8d730d0", "Sport", "Green", "Used", "Description for Car 14", "Euro 2", "Hybrid", "Manual", 114, null, "Brand14", 1400, "Model14", null, 140000m, null, "5856091b-d323-445d-a07b-5c28db656393", 2014 },
                    { "36afa6cd-0f71-40f1-986a-b20fae1f78bb", "Sport", "Red", "Used", "Description for Car 3", "Euro 3", "Diesel", "Automatic", 103, null, "Brand3", 300, "Model3", null, 30000m, null, "037f69eb-1390-435f-a085-e738fb60e93e", 2003 },
                    { "5a05bc29-0e36-4132-9d2b-95de93456309", "Sport", "Black", "Used", "Description for Car 12", "Euro 0", "Gasoline", "Automatic", 112, null, "Brand12", 1200, "Model12", null, 120000m, null, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2012 },
                    { "6001b5e5-ea44-448c-a095-2d3641c890c4", "Sport", "Silver", "Used", "Description for Car 11", "Euro 5", "Hybrid", "Automatic", 111, null, "Brand11", 1100, "Model11", null, 110000m, null, "037f69eb-1390-435f-a085-e738fb60e93e", 2011 },
                    { "7415ad55-ede4-4a8e-ac2a-c06ccfc41511", "Sport", "Gray", "Used", "Description for Car 10", "Euro 4", "Hybrid", "Manual", 110, null, "Brand10", 1000, "Model10", null, 100000m, null, "5856091b-d323-445d-a07b-5c28db656393", 2010 },
                    { "76c322d3-45a4-4f07-b776-b925c08ad917", "Sport", "Black", "Used", "Description for Car 7", "Euro 1", "Electric", "Manual", 107, null, "Brand7", 700, "Model7", null, 70000m, null, "5856091b-d323-445d-a07b-5c28db656393", 2007 },
                    { "7f31cf7c-5932-46f2-a5c1-68b62a2d4402", "Sport", "Blue", "Used", "Description for Car 21", "Euro 3", "Gasoline", "Manual", 121, null, "Brand21", 2100, "Model21", null, 210000m, null, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2021 },
                    { "7f7bf063-88ae-4e90-b701-7df185af4e3a", "Sport", "White", "Used", "Description for Car 20", "Euro 2", "Electric", "Automatic", 120, null, "Brand20", 2000, "Model20", null, 200000m, null, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2020 },
                    { "80b015ba-811d-4721-9305-209e47afe996", "Sport", "Blue", "Used", "Description for Car 18", "Euro 0", "Gasoline", "Automatic", 118, null, "Brand18", 1800, "Model18", null, 180000m, null, "5856091b-d323-445d-a07b-5c28db656393", 2018 },
                    { "85619d0d-4f95-4c25-97b8-7869df3834e6", "Sport", "White", "Used", "Description for Car 19", "Euro 1", "Gasoline", "Automatic", 119, null, "Brand19", 1900, "Model19", null, 190000m, null, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2019 },
                    { "8d19c0cf-0e66-4edc-ad27-f8a49ff8208f", "Sport", "White", "Used", "Description for Car 0", "Euro 0", "Diesel", "Automatic", 100, null, "Brand0", 0, "Model0", null, 0m, null, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2000 },
                    { "8f20ae39-6fdf-43b1-9e1b-f2c8458b011f", "Sport", "Blue", "Used", "Description for Car 22", "Euro 4", "Gasoline", "Automatic", 122, null, "Brand22", 2200, "Model22", null, 220000m, null, "3035f543-8ce5-457d-8073-c086473cf18a", 2022 },
                    { "9780e7f2-421a-4499-8d85-a23a7841380f", "Sport", "Silver", "Used", "Description for Car 1", "Euro 1", "Hybrid", "Automatic", 101, null, "Brand1", 100, "Model1", null, 10000m, null, "037f69eb-1390-435f-a085-e738fb60e93e", 2001 },
                    { "af68e7ce-1ae4-40ca-959a-a0de24817592", "Sport", "Red", "Used", "Description for Car 17", "Euro 5", "Gasoline", "Manual", 117, null, "Brand17", 1700, "Model17", null, 170000m, null, "3035f543-8ce5-457d-8073-c086473cf18a", 2017 }
                });

            migrationBuilder.InsertData(
                table: "Motorcycles",
                columns: new[] { "Id", "Category", "Color", "Condition", "Description", "EuroStandard", "FuelType", "Gearbox", "HorsePower", "ImageUrl", "Make", "Mileage", "Model", "OwnerId", "Price", "RequiredLicense", "UserId", "Year" },
                values: new object[,]
                {
                    { "b5ceb029-de22-4803-83b6-9dcf01e83159", "Sport", "Silver", "Used", "Description for Car 4", "Euro 4", "Hybrid", "Manual", 104, null, "Brand4", 400, "Model4", null, 40000m, null, "037f69eb-1390-435f-a085-e738fb60e93e", 2004 },
                    { "d5eb93f9-fb81-49b6-a22d-963a18e593f9", "Sport", "Silver", "Used", "Description for Car 6", "Euro 0", "Electric", "Manual", 106, null, "Brand6", 600, "Model6", null, 60000m, null, "037f69eb-1390-435f-a085-e738fb60e93e", 2006 },
                    { "ef84e0de-0db0-414e-8f02-120f3116a4f7", "Sport", "Black", "Used", "Description for Car 13", "Euro 1", "Diesel", "Automatic", 113, null, "Brand13", 1300, "Model13", null, 130000m, null, "3035f543-8ce5-457d-8073-c086473cf18a", 2013 },
                    { "facb0007-fded-4917-9125-0459c8b1d989", "Sport", "Gray", "Used", "Description for Car 8", "Euro 2", "Hybrid", "Automatic", 108, null, "Brand8", 800, "Model8", null, 80000m, null, "037f69eb-1390-435f-a085-e738fb60e93e", 2008 }
                });

            migrationBuilder.InsertData(
                table: "Trucks",
                columns: new[] { "Id", "Axles", "Color", "Condition", "Description", "EuroStandard", "FuelType", "Gearbox", "HorsePower", "ImageUrl", "Make", "Mileage", "Model", "OwnerId", "Price", "UserId", "Year" },
                values: new object[,]
                {
                    { "0bde06d5-5fc1-4488-b3a6-314304ccf8ba", 8, "Red", "Used", "Description for Car 13", "Euro 1", "Gasoline", "Manual", 113, null, "Brand13", 1300, "Model13", null, 130000m, "3035f543-8ce5-457d-8073-c086473cf18a", 2013 },
                    { "10e0b30d-5cec-4a0f-85fa-f26a81d886d5", 8, "Silver", "Used", "Description for Car 2", "Euro 2", "Gasoline", "Manual", 102, null, "Brand2", 200, "Model2", null, 20000m, "296290bd-402b-4dc7-922f-3586f8d0c882", 2002 },
                    { "21b48da4-1d2a-44c3-8a0e-5a74f36fb193", 8, "Black", "Used", "Description for Car 14", "Euro 2", "Gasoline", "Manual", 114, null, "Brand14", 1400, "Model14", null, 140000m, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2014 },
                    { "2c995194-67e8-4987-9916-e29561950601", 8, "Silver", "Used", "Description for Car 7", "Euro 1", "Diesel", "Automatic", 107, null, "Brand7", 700, "Model7", null, 70000m, "296290bd-402b-4dc7-922f-3586f8d0c882", 2007 },
                    { "3040f82b-bf20-4b5a-bfd4-9936074da328", 8, "Green", "Used", "Description for Car 4", "Euro 4", "Diesel", "Automatic", 104, null, "Brand4", 400, "Model4", null, 40000m, "296290bd-402b-4dc7-922f-3586f8d0c882", 2004 },
                    { "3833da4a-76ef-41c9-b897-f48bfbfec16a", 8, "Silver", "Used", "Description for Car 21", "Euro 3", "Gasoline", "Automatic", 121, null, "Brand21", 2100, "Model21", null, 210000m, "5856091b-d323-445d-a07b-5c28db656393", 2021 },
                    { "3970f922-c8ce-471f-ad0b-5ad9ef65f39f", 8, "Green", "Used", "Description for Car 0", "Euro 0", "Gasoline", "Automatic", 100, null, "Brand0", 0, "Model0", null, 0m, "3035f543-8ce5-457d-8073-c086473cf18a", 2000 },
                    { "43ce5074-f7c2-4012-80f8-c01769b763e6", 8, "Green", "Used", "Description for Car 15", "Euro 3", "Electric", "Automatic", 115, null, "Brand15", 1500, "Model15", null, 150000m, "5856091b-d323-445d-a07b-5c28db656393", 2015 },
                    { "48e0c702-a37b-4010-9153-b8de1a4aa787", 8, "Black", "Used", "Description for Car 19", "Euro 1", "Hybrid", "Manual", 119, null, "Brand19", 1900, "Model19", null, 190000m, "3035f543-8ce5-457d-8073-c086473cf18a", 2019 },
                    { "57fd16f8-9ff3-4229-887c-16d8c3ac97fa", 8, "Gray", "Used", "Description for Car 3", "Euro 3", "Hybrid", "Automatic", 103, null, "Brand3", 300, "Model3", null, 30000m, "3035f543-8ce5-457d-8073-c086473cf18a", 2003 },
                    { "646b0674-83d6-47f4-8aa9-518ec4c8ab84", 8, "Silver", "Used", "Description for Car 18", "Euro 0", "Diesel", "Automatic", 118, null, "Brand18", 1800, "Model18", null, 180000m, "037f69eb-1390-435f-a085-e738fb60e93e", 2018 },
                    { "824bf77b-d3cf-4571-9aaa-f5b5fdbb6e81", 8, "Green", "Used", "Description for Car 12", "Euro 0", "Gasoline", "Automatic", 112, null, "Brand12", 1200, "Model12", null, 120000m, "3035f543-8ce5-457d-8073-c086473cf18a", 2012 },
                    { "838e1c1a-729c-4191-94ec-80d4737c03ef", 8, "Red", "Used", "Description for Car 1", "Euro 1", "Gasoline", "Manual", 101, null, "Brand1", 100, "Model1", null, 10000m, "296290bd-402b-4dc7-922f-3586f8d0c882", 2001 },
                    { "9a39a840-8f7b-4f64-9b66-5fffcbb4a9ef", 8, "Green", "Used", "Description for Car 11", "Euro 5", "Hybrid", "Automatic", 111, null, "Brand11", 1100, "Model11", null, 110000m, "296290bd-402b-4dc7-922f-3586f8d0c882", 2011 },
                    { "a6f7f89a-f993-40ab-84c6-1530f2ca6c4b", 8, "Red", "Used", "Description for Car 9", "Euro 3", "Gasoline", "Automatic", 109, null, "Brand9", 900, "Model9", null, 90000m, "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5", 2009 },
                    { "aa1a84f2-a156-448e-94fa-96ff0b434c22", 8, "Blue", "Used", "Description for Car 17", "Euro 5", "Diesel", "Automatic", 117, null, "Brand17", 1700, "Model17", null, 170000m, "037f69eb-1390-435f-a085-e738fb60e93e", 2017 },
                    { "acda0415-f1d1-4844-918e-1a3dce0f8e0a", 8, "Green", "Used", "Description for Car 6", "Euro 0", "Electric", "Automatic", 106, null, "Brand6", 600, "Model6", null, 60000m, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2006 },
                    { "b7567532-53e9-4e50-9445-05ef55a58195", 8, "Red", "Used", "Description for Car 5", "Euro 5", "Gasoline", "Automatic", 105, null, "Brand5", 500, "Model5", null, 50000m, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2005 },
                    { "cb87016a-f60b-48fc-99fe-c9c0e3284357", 8, "Black", "Used", "Description for Car 22", "Euro 4", "Electric", "Manual", 122, null, "Brand22", 2200, "Model22", null, 220000m, "5856091b-d323-445d-a07b-5c28db656393", 2022 },
                    { "cd02a553-b7f9-4e8d-97f1-a683d5681e81", 8, "Black", "Used", "Description for Car 10", "Euro 4", "Electric", "Automatic", 110, null, "Brand10", 1000, "Model10", null, 100000m, "824856e7-f56b-4f18-807f-d75e04c81ed0", 2010 },
                    { "e7aead58-1004-4c90-a8bb-37fcbaabe3aa", 8, "Gray", "Used", "Description for Car 16", "Euro 4", "Diesel", "Automatic", 116, null, "Brand16", 1600, "Model16", null, 160000m, "5856091b-d323-445d-a07b-5c28db656393", 2016 },
                    { "f242f945-17b9-43ca-8d25-a4723c8176db", 8, "Green", "Used", "Description for Car 8", "Euro 2", "Hybrid", "Automatic", 108, null, "Brand8", 800, "Model8", null, 80000m, "037f69eb-1390-435f-a085-e738fb60e93e", 2008 },
                    { "f5a504fb-c314-49df-a026-ab7b190ccc6f", 8, "Black", "Used", "Description for Car 20", "Euro 2", "Diesel", "Manual", 120, null, "Brand20", 2000, "Model20", null, 200000m, "5856091b-d323-445d-a07b-5c28db656393", 2020 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "0118d801-3738-4c18-a1a7-8365cfaf1115");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "1a37253e-f728-40de-9cc1-eece0c226851");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "27e6fde3-c98d-49c8-b90b-948a0aa48fba");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "2c0055dd-8ff0-428d-b8c4-e36c39881706");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "32da0e58-929a-4f5d-b096-e8b7d6a9ca69");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "3cc7b998-f044-4b59-a736-da8c35216146");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "4f5fa115-869c-4407-aca0-3c8219369c91");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "62d176a7-679b-4adf-9b71-6b05a65acb43");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "65c247c4-4090-4e5b-9e3f-41c0a6bcaf89");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "746766a5-e688-4f3d-ba3d-343a663e0504");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "807bc866-6919-4fef-9ce9-9e9247c998c1");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "86c4a8d7-cbcf-4b07-adce-2537bf52aa58");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "871f8c4a-8af1-4c84-b05a-cd4a2cc0e2e0");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "8951e288-74ac-4064-bfb9-8b02225237f3");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "98d59966-147f-4e7c-ae59-272c094f1a42");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "99b23c21-be04-4dbe-a26b-fe479b9565c5");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "a059ae35-beea-4525-886a-d67205ca7752");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "a0ce2b3d-4dc4-4186-9e8f-35099bd13ae9");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "a2074234-22aa-4a53-b3e8-1e16a16d5bbe");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "c6a9da32-950d-4398-8d21-ef1fd62af989");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "e45c88c3-c033-422c-869d-dd8840942aeb");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "f5c9d9ce-4fbb-462d-b706-0eec7edba8dc");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "f8a757ad-043e-48a9-8b12-f681104b2602");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "00f49ed2-1598-433f-a9f8-d559bae0b89a");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "21ad2539-b955-4470-ac81-ebf764f0d580");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "22447127-94b0-412a-8b43-c9ad8f3a6894");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "26399eea-229c-446d-9468-06fe6b9d008b");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "335ab57c-270f-4e9a-b470-4e1834660d28");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "35c0f1f3-32b5-404f-b39d-8b31d8d730d0");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "36afa6cd-0f71-40f1-986a-b20fae1f78bb");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "5a05bc29-0e36-4132-9d2b-95de93456309");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "6001b5e5-ea44-448c-a095-2d3641c890c4");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "7415ad55-ede4-4a8e-ac2a-c06ccfc41511");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "76c322d3-45a4-4f07-b776-b925c08ad917");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "7f31cf7c-5932-46f2-a5c1-68b62a2d4402");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "7f7bf063-88ae-4e90-b701-7df185af4e3a");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "80b015ba-811d-4721-9305-209e47afe996");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "85619d0d-4f95-4c25-97b8-7869df3834e6");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "8d19c0cf-0e66-4edc-ad27-f8a49ff8208f");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "8f20ae39-6fdf-43b1-9e1b-f2c8458b011f");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "9780e7f2-421a-4499-8d85-a23a7841380f");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "af68e7ce-1ae4-40ca-959a-a0de24817592");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "b5ceb029-de22-4803-83b6-9dcf01e83159");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "d5eb93f9-fb81-49b6-a22d-963a18e593f9");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "ef84e0de-0db0-414e-8f02-120f3116a4f7");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: "facb0007-fded-4917-9125-0459c8b1d989");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "0bde06d5-5fc1-4488-b3a6-314304ccf8ba");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "10e0b30d-5cec-4a0f-85fa-f26a81d886d5");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "21b48da4-1d2a-44c3-8a0e-5a74f36fb193");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "2c995194-67e8-4987-9916-e29561950601");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "3040f82b-bf20-4b5a-bfd4-9936074da328");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "3833da4a-76ef-41c9-b897-f48bfbfec16a");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "3970f922-c8ce-471f-ad0b-5ad9ef65f39f");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "43ce5074-f7c2-4012-80f8-c01769b763e6");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "48e0c702-a37b-4010-9153-b8de1a4aa787");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "57fd16f8-9ff3-4229-887c-16d8c3ac97fa");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "646b0674-83d6-47f4-8aa9-518ec4c8ab84");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "824bf77b-d3cf-4571-9aaa-f5b5fdbb6e81");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "838e1c1a-729c-4191-94ec-80d4737c03ef");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "9a39a840-8f7b-4f64-9b66-5fffcbb4a9ef");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "a6f7f89a-f993-40ab-84c6-1530f2ca6c4b");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "aa1a84f2-a156-448e-94fa-96ff0b434c22");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "acda0415-f1d1-4844-918e-1a3dce0f8e0a");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "b7567532-53e9-4e50-9445-05ef55a58195");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "cb87016a-f60b-48fc-99fe-c9c0e3284357");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "cd02a553-b7f9-4e8d-97f1-a683d5681e81");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "e7aead58-1004-4c90-a8bb-37fcbaabe3aa");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "f242f945-17b9-43ca-8d25-a4723c8176db");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: "f5a504fb-c314-49df-a026-ab7b190ccc6f");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ImageUrl",
                table: "Trucks",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "ImageUrl",
                table: "Motorcycles",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "ImageUrl",
                table: "Cars",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

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
    }
}
