using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsWeb.Data.Migrations
{
    public partial class newProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DealerId", "Description", "ImageUrl", "IsDeleted", "ManufacturerId", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[] { 4, 1, 1, "In a piston engine, either a timing belt (also called a cambelt) or timing chain or set of timing gears is a perishable component used to synchronize the rotation of the crankshaft and the camshaft.", "https://cdn.autodoc.de/thumb?id=709611&m=0&n=0&lng=en&rev=94077829", false, 3, "Timing belt", 55.00m, 0, "5e84f853-e25f-4a90-8f2b-448ffdeed35e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a558517-6bd0-4da4-9a6c-e5d92df0a945",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee52668c-40a8-4746-bb70-03b010b7a10d", "AQAAAAEAACcQAAAAEJX3gadODd5Cawwt0/EWjqGQFEWJhSwLWCvf6l4aCt4hnjujK3hs0PxjSZspc6rTQA==", "e86d1f37-7f9c-4412-91c7-0e1683a3280f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35dc8055-e6de-40d0-97f7-791088c86d37", "AQAAAAEAACcQAAAAED52GAl7LB4A0iza40IhRV3UM2TezDohb1NSGpCUtd2vWmGPary/u6yiv7nnqdxnuQ==", "537f9dda-2dd4-49e4-b8af-bdd8020f2ca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c44c2f8-244a-4cdc-b8bf-4e17f96a3e2e", "AQAAAAEAACcQAAAAEIVVffxyOdE9nSH0oEBSQOF4Weh0uOfxmeF33UdLjS0a6hspywSm3iNDWJYQ6Q7j6A==", "5056a7eb-1cf4-41c4-ae11-2c246b1a02fc" });
        }
    }
}
