using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsWeb.Data.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 2, "user:fullname", "Jacob Lugo", "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 3, "user:fullname", "Davis Pope", "5e84f853-e25f-4a90-8f2b-448ffdeed35e" }
                });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ce37d5d-5d38-4bdf-9420-85e4d86603f7", "AQAAAAEAACcQAAAAEPnnFgaWmQ2E6MXXiJvVvGtdZ4zmS7t+cTR3/KNyA38Wlqs7A3LWhK73EZ7VbJJ6Xw==", "52bb3711-0ab0-4916-9368-3afdf603ae74" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1eb938d-623e-4b9b-bc54-7742727213c9", null, "57be7de0-9cb1-4ca9-b609-16490a12b955" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "615b9597-55fd-418f-8166-afa1242e6cdd", null, "5b944f6f-f943-44d5-ba68-57985fa48c29" });
        }
    }
}
