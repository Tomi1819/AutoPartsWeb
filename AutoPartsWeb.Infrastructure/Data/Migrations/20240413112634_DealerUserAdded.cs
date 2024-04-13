using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsWeb.Data.Migrations
{
    public partial class DealerUserAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9b08982-5ff3-49a5-8a83-5f639a6efd03", "AQAAAAEAACcQAAAAEPqykXT1kPhxqTU3zboEZ3p+rjhdrJ5U8eB5K6F9VtQwF08NiTFEQuKI9uRXFMHWMQ==", "5579a4a1-9c6b-4323-8b14-b5e61f59fcd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ca74296-d185-41af-996a-7847516a412f", "admin@mail.com", "AQAAAAEAACcQAAAAEJH9pFPZecGH1uHFnSurk1kyeTskjywWl/vFO+fX2iHU6HJIewF0kY/obP/c/QJuIw==", "4f2b9b1b-fd92-416f-b301-a7a3a4b99840" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1a558517-6bd0-4da4-9a6c-e5d92df0a945", 0, "38350159-bf6a-441b-b54f-920212e3410e", "dealer@mail.com", false, "Jake", "Paul", false, null, "dealer@mail.com", "dealer@mail.com", "AQAAAAEAACcQAAAAEGT151vor56OUHNTM+kqkqiIcHA832uFvaAYCZr129jfKI9A0oY3cQ/S1BpvieRZqQ==", null, false, "1677ac3d-3f7b-4a69-873f-8fd69beedf2f", false, "dealer@mail.com" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price" },
                values: new object[] { "BILSTEIN EVO T2 track performance, a winning combination of BILSTEIN monotube technology and ST suspensions coilovers.", "https://www.tuningblog.eu/wp-content/uploads/2017/03/Bilstein-EVO-T2-900PS-Kraftkur-BMW-M3-E92-1.jpg", 899.99m });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "UserId", "Value" },
                values: new object[] { 2, "dea12856-c198-4129-b3f3-b893d8395082", 4 });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 4, "user:fullname", "Jake Paul", "1a558517-6bd0-4da4-9a6c-e5d92df0a945" });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "1a558517-6bd0-4da4-9a6c-e5d92df0a945");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[] { "A brake pad is a component of disc brakes, used in automotive and other applications.", "https://cdn.shopify.com/s/files/1/0234/1883/5859/products/fcpgroton-volvo-brake-pads_480x480.jpg?v=1588090853", "Brake Pads", 65.00m, 20, "1a558517-6bd0-4da4-9a6c-e5d92df0a945" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { 3, "1a558517-6bd0-4da4-9a6c-e5d92df0a945" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a558517-6bd0-4da4-9a6c-e5d92df0a945");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "514bfa6c-8943-42c5-a4ea-78e542d55cd3", "AQAAAAEAACcQAAAAEKR0WYPPz2H0ZbV153lS4BUwKHoJDqpvDPDJ0iSbANHsWAVNZpsp1zTB4C5ydt4hjA==", "c25d7867-dfee-48e9-8f64-512eda92448b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ce37d5d-5d38-4bdf-9420-85e4d86603f7", "admint@mail.com", "AQAAAAEAACcQAAAAEPnnFgaWmQ2E6MXXiJvVvGtdZ4zmS7t+cTR3/KNyA38Wlqs7A3LWhK73EZ7VbJJ6Xw==", "52bb3711-0ab0-4916-9368-3afdf603ae74" });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price" },
                values: new object[] { "BILSTEIN EVO T2 track performance suspension.", "https://performance.bilstein.com/wp-content/uploads/2023/10/BILSTEIN-EVO-T2.png", 250.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[] { "Brake pads convert the kinetic energy of a vehicle to thermal energy through friction. Two brake pads are contained in the brake with their friction surfaces facing the rotor.", "https://www.buybrakes.com/images/product/brembo-oe-replacement-brake-pads.jpg", "Brake pads", 55.00m, 30, "5e84f853-e25f-4a90-8f2b-448ffdeed35e" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Value" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "UserId", "Value" },
                values: new object[] { 1, "5e84f853-e25f-4a90-8f2b-448ffdeed35e", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { 2, "5e84f853-e25f-4a90-8f2b-448ffdeed35e" });
        }
    }
}
