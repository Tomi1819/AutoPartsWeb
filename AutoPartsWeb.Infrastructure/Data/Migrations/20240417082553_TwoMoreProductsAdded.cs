using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsWeb.Data.Migrations
{
    public partial class TwoMoreProductsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "StockQuantity",
                value: 10);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DealerId", "Description", "ImageUrl", "IsDeleted", "ManufacturerId", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[] { 5, 2, 1, "A disc brake is a type of brake that uses the calipers to squeeze pairs of pads against a disc or a rotor to create friction.", "https://www.brembo.com/en/PublishingImages/auto/primo-equipaggiamento/prodotti/dischi/BREMBO-16-07-13-14803_.jpg", false, 3, "Car Breake Disc", 89.99m, 20, "1a558517-6bd0-4da4-9a6c-e5d92df0a945" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ProductId", "UserId", "Value" },
                values: new object[] { 4, 4, "5e84f853-e25f-4a90-8f2b-448ffdeed35e", 4 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ProductId", "UserId", "Value" },
                values: new object[] { 5, 5, "5e84f853-e25f-4a90-8f2b-448ffdeed35e", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a558517-6bd0-4da4-9a6c-e5d92df0a945",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4c1e493-748a-43ff-8361-cad2bf3f4706", "AQAAAAEAACcQAAAAEG63auDR8XZ/lZoe1Ryc/3tpuMvwlyQkuGVTzGVDaKY9aaJp0gHoJfaOUztQY1MDtg==", "c8e0273d-df8e-492f-b01e-211867e0af70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f22228bd-c207-4e84-9e27-b65480e1305d", "AQAAAAEAACcQAAAAEL1xICUK5M7VCQ7nSjmUKGzpy0FikRtPLECax1gCGebVe7sgTW/XlXuJVl56BUwe/w==", "97a207c7-d069-4d32-a3f5-4a60f9708f50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dd6744a-a2f4-4179-a02d-b23d6a7bae60", "AQAAAAEAACcQAAAAEJr1OSQ5I4oH60tg85M8hB08Rfys16WXadJ/GjM75c4JQKmANMtyed+BWe3TUSGD+Q==", "94dfd3f9-9822-403b-bed3-8ae41e05ca1d" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "StockQuantity",
                value: 0);
        }
    }
}
