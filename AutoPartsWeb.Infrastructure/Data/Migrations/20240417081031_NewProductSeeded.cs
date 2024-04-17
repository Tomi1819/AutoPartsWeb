using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsWeb.Data.Migrations
{
    public partial class NewProductSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a558517-6bd0-4da4-9a6c-e5d92df0a945",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6358e5d9-3ce0-41e8-8659-9cb18f3f41c1", "AQAAAAEAACcQAAAAEGQKkTMP1TtqnMCe+UyDlru4gLYGFQnHRf/vdJI90G1Av8dT680Kd9+t656aQpmhkA==", "7bc0845f-666d-43b6-8cbe-280fff7982b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a686fc69-f722-4797-8e4e-4b6f5b6f19f9", "AQAAAAEAACcQAAAAEJ1q/Rlgg2X+vPzok1MxDepPzV4lVblvTk6i2Y8bvVRQ98w+8Jl49ODGN12lxDyboA==", "57f54edb-0039-4e44-8d91-f8a49b4f491a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17433c39-ea31-4c73-9798-e376b201c464", "AQAAAAEAACcQAAAAEL2BfE2IXqPvFNF1JTeZPNZfmlUvIHxednnVNRS+Jx83qKrgyS8LvOaPgLiHOWK08A==", "05d0ee1d-cf0e-4755-a7c5-01a3fff3a954" });
        }
    }
}
