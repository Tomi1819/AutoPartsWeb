using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsWeb.Data.Migrations
{
    public partial class SecondInitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5e84f853-e25f-4a90-8f2b-448ffdeed35e", 0, "973d1e5c-24d3-48eb-b87d-c5a35987c44d", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", null, null, false, "ef5fac3c-48fb-48cb-9d48-23f8f499748e", false, "guest@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "4b087332-db7c-4812-b42d-f0899ee7645e", "admint@mail.com", false, false, null, "admin@mail.com", "admint@mail.com", null, null, false, "b80a0084-14ce-4408-b846-c423b2be00fc", false, "admin@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Engine" },
                    { 2, false, "Brakes" },
                    { 3, false, "Suspension" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Country", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Germany", false, "Bosh" },
                    { 2, "Germany", false, "Bilstein" },
                    { 3, "Italy", false, "Brembo" }
                });

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "Id", "CompanyName", "CompanyNumber", "Description", "IsDeleted", "Name", "UserId" },
                values: new object[] { 1, "AutoTrader", "7516425943", "The biggest auto parts dealer in Bulgaria.", false, "Dimitrichko", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DealerId", "OrderDate", "Status" },
                values: new object[] { 1, 1, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In progress" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DealerId", "Description", "ImageUrl", "IsDeleted", "ManufacturerId", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1, "An automotive battery, or car battery, is a rechargeable battery that is used to start a motor vehicle.", "https://cdn.media.halfords.com/i/washford/950295/Halfords-HB063-Lead-Acid-12V-Car-Battery-3-Year-Guarantee?fmt=auto&qlt=default&$sfcc_tile$&w=680", false, 1, "Battery", 120.00m, 15, "5e84f853-e25f-4a90-8f2b-448ffdeed35e" },
                    { 2, 3, 1, "BILSTEIN EVO T2 track performance suspension.", "https://performance.bilstein.com/wp-content/uploads/2023/10/BILSTEIN-EVO-T2.png", false, 2, "BilsteinEvoT2", 250.00m, 5, "5e84f853-e25f-4a90-8f2b-448ffdeed35e" },
                    { 3, 2, 1, "Brake pads convert the kinetic energy of a vehicle to thermal energy through friction. Two brake pads are contained in the brake with their friction surfaces facing the rotor.", "https://www.buybrakes.com/images/product/brembo-oe-replacement-brake-pads.jpg", false, 3, "Brake pads", 55.00m, 30, "5e84f853-e25f-4a90-8f2b-448ffdeed35e" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ProductId", "UserId", "Value" },
                values: new object[] { 1, 3, "5e84f853-e25f-4a90-8f2b-448ffdeed35e", 4 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ProductId", "UserId", "Value" },
                values: new object[] { 2, 1, "5e84f853-e25f-4a90-8f2b-448ffdeed35e", 5 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ProductId", "UserId", "Value" },
                values: new object[] { 3, 2, "5e84f853-e25f-4a90-8f2b-448ffdeed35e", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e84f853-e25f-4a90-8f2b-448ffdeed35e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");
        }
    }
}
