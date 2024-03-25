﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsWeb.Data.Migrations
{
    public partial class NewDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "DealerId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Dealer identifier");

            migrationBuilder.AddColumn<int>(
                name: "DealerId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Dealer identifier");

            migrationBuilder.CreateTable(
                name: "Dealers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Dealer identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Dealer name"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Comapany name"),
                    CompanyNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "Comapany number"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Dealer description"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dealers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Dealers table");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DealerId",
                table: "Products",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DealerId",
                table: "Orders",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_UserId",
                table: "Dealers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Dealers_DealerId",
                table: "Orders",
                column: "DealerId",
                principalTable: "Dealers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Dealers_DealerId",
                table: "Products",
                column: "DealerId",
                principalTable: "Dealers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Dealers_DealerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Dealers_DealerId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Dealers");

            migrationBuilder.DropIndex(
                name: "IX_Products_DealerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DealerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DealerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DealerId",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "User identificator");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5e84f853-e25f-4a90-8f2b-448ffdeed35e", 0, "0ef3acc1-62a2-41f3-b6a1-9b77ae4a6a1f", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", null, null, false, "e554d530-2bb2-437c-8144-4f32009ffe18", false, "guest@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "75192edd-a526-412f-93bc-5ea668c70775", "admint@mail.com", false, false, null, "admin@mail.com", "admint@mail.com", null, null, false, "16c46ba7-21cf-4ee4-9633-1cd264becbeb", false, "admin@mail.com" }
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
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "IsDeleted", "ManufacturerId", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[] { 1, 1, "An automotive battery, or car battery, is a rechargeable battery that is used to start a motor vehicle.", "https://cdn.media.halfords.com/i/washford/950295/Halfords-HB063-Lead-Acid-12V-Car-Battery-3-Year-Guarantee?fmt=auto&qlt=default&$sfcc_tile$&w=680", false, 1, "Battery", 120.00m, 15, "5e84f853-e25f-4a90-8f2b-448ffdeed35e" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "IsDeleted", "ManufacturerId", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[] { 2, 3, "BILSTEIN EVO T2 track performance suspension.", "https://performance.bilstein.com/wp-content/uploads/2023/10/BILSTEIN-EVO-T2.png", false, 2, "BilsteinEvoT2", 250.00m, 5, "5e84f853-e25f-4a90-8f2b-448ffdeed35e" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "IsDeleted", "ManufacturerId", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[] { 3, 2, "Brake pads convert the kinetic energy of a vehicle to thermal energy through friction. Two brake pads are contained in the brake with their friction surfaces facing the rotor.", "https://www.buybrakes.com/images/product/brembo-oe-replacement-brake-pads.jpg", false, 3, "Brake pads", 55.00m, 30, "5e84f853-e25f-4a90-8f2b-448ffdeed35e" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
