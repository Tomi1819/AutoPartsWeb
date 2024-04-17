using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsWeb.Data.Migrations
{
    public partial class MoreDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a558517-6bd0-4da4-9a6c-e5d92df0a945",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0738f9a-04d4-41a1-95c6-509bde6173f8", "AQAAAAEAACcQAAAAEBtqeHCju81rVUDHt4eWi50kNbKNzn5h4pzBixvxLJIBn+/3hQPYT/7HzGU7iATT2Q==", "a9678978-ff21-4cb9-949f-273e97a8cba3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31ea8d21-8bc9-4323-9f6f-a177ae89ea2e", "AQAAAAEAACcQAAAAENknSstL/HJqH5yoUStyyqZq/AN0TybIol+rWqCghZcZWC4V00pxPVFjfaOU1MdQHA==", "764219d3-1a67-4c69-b81c-fd19a64ad0fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0fb5426-29be-4136-bdac-979448ee6320", "AQAAAAEAACcQAAAAEBM/1QBXjp1VaRzF8roR2E3aamEQ+J9wnLOfpglrs7CPcHIhS7MsZGJRrmHNaAObfg==", "de1abf68-0031-4e28-a9b0-1721e0b1580b" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { 4, false, "Exterior" });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Country", "IsDeleted", "Name" },
                values: new object[] { 4, "Germany", false, "Osram" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DealerId", "Description", "ImageUrl", "IsDeleted", "ManufacturerId", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[] { 6, 4, 1, "Osram Xenarc 66140 D1S 35W Xenon Headlight HID Bulb", "https://www.hidconcept.com/cdn/shop/products/HID-OS-D1S-4K-X1-1_1500x.jpg?v=1657917235", false, 4, "Osram Xenarc", 52.25m, 20, "1a558517-6bd0-4da4-9a6c-e5d92df0a945" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DealerId", "Description", "ImageUrl", "IsDeleted", "ManufacturerId", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[] { 7, 4, 1, "The Bosch Aerotwin are designed to maximize wiping quality, last longer and are decisively less noisy than traditional wiper blades. The Aerotwin range of wiper blades promotes safer driving by providing a consistently clear vision of the road ahead.", "https://www.wiperblades.co.uk/media/IMG5A9FAA7E88BC3/1000/1-ar-packaging.webp", false, 1, "Aerotwin Single Blade", 45.12m, 30, "1a558517-6bd0-4da4-9a6c-e5d92df0a945" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ProductId", "UserId", "Value" },
                values: new object[] { 6, 6, "1a558517-6bd0-4da4-9a6c-e5d92df0a945", 5 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ProductId", "UserId", "Value" },
                values: new object[] { 7, 7, "1a558517-6bd0-4da4-9a6c-e5d92df0a945", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a558517-6bd0-4da4-9a6c-e5d92df0a945",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "158c9315-d73c-434e-97d9-55757ae5ff48", "AQAAAAEAACcQAAAAEN1gLanhddNqcpnvVd6+Xp65n4mo2dIOflsCDl0PDIkfW2Ev/mYQyazoDCyNyRQDSg==", "29fe670b-3bd0-47a6-91e5-40a802463b56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4acd46b1-82c1-4c80-9bc7-44a9d9c0df66", "AQAAAAEAACcQAAAAEMB1kDE6VLIzXtxLLLrDI3P7VQy2TudGbzhtEMHloP6KvNaHQIE8K6I6HAQFYStzaw==", "6b32f138-a520-43fd-8e93-5a5bfaf62f01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63472bf6-3eb6-4dcc-94c0-4dc00797f917", "AQAAAAEAACcQAAAAEEbO5nFmmDf5lDNAVL753iNgRPDT+gM7qroPuTCW6EgQFzoqqAYwRsUlQohXMXHBWw==", "cc08ecf5-fe72-4980-aaef-e1049ebd91c9" });
        }
    }
}
