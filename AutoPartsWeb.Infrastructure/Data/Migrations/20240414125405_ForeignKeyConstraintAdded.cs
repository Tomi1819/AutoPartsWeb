using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsWeb.Data.Migrations
{
    public partial class ForeignKeyConstraintAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Dealers_UserId",
                table: "Dealers");

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

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_UserId",
                table: "Dealers",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Dealers_UserId",
                table: "Dealers");

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

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_UserId",
                table: "Dealers",
                column: "UserId");
        }
    }
}
