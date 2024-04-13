using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsWeb.Data.Migrations
{
    public partial class TypoFixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a558517-6bd0-4da4-9a6c-e5d92df0a945",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc28beca-6ad1-4a7a-a13b-9cca071e1798", "AQAAAAEAACcQAAAAEGou4j/+D6d7rwhlfq7RIVixQo5VE6qF33CcRQUlqTxzg0gEBPO0xtp+DU9vDyfwhw==", "c01c8893-66ea-440c-a9fd-e043e3e23dba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec41726e-5e58-4a33-af72-f408a90e9951", "AQAAAAEAACcQAAAAEJZODGXhdFzO2MFQ/iJv+BzRE82MeV5UtmKle6brSwufIYChPbG9KWS2EtqsWkPkcQ==", "5fd7d0da-45d4-4628-8d57-074c82fa7036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8af6590-3724-4751-93fb-d69d9d76158e", "AQAAAAEAACcQAAAAEG1ns9MtznAmXVGSL1jHIlPpdsZlSDIvRcJkTCr89FCu15HZArr2X8MdtPwj/jayPg==", "831f6579-7169-4f04-a97e-2d716e16f31f" });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bosch");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.buybrakes.com/images/product/bilstein-6112-suspension-kit.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQQZ_AsODk3OKfTO8mqm9ZHU56YW5KL0ovBXFdmipZvg&s");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a558517-6bd0-4da4-9a6c-e5d92df0a945",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38350159-bf6a-441b-b54f-920212e3410e", "AQAAAAEAACcQAAAAEGT151vor56OUHNTM+kqkqiIcHA832uFvaAYCZr129jfKI9A0oY3cQ/S1BpvieRZqQ==", "1677ac3d-3f7b-4a69-873f-8fd69beedf2f" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ca74296-d185-41af-996a-7847516a412f", "AQAAAAEAACcQAAAAEJH9pFPZecGH1uHFnSurk1kyeTskjywWl/vFO+fX2iHU6HJIewF0kY/obP/c/QJuIw==", "4f2b9b1b-fd92-416f-b301-a7a3a4b99840" });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bosh");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.tuningblog.eu/wp-content/uploads/2017/03/Bilstein-EVO-T2-900PS-Kraftkur-BMW-M3-E92-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://cdn.shopify.com/s/files/1/0234/1883/5859/products/fcpgroton-volvo-brake-pads_480x480.jpg?v=1588090853");
        }
    }
}
