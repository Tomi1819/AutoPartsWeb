using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsWeb.Data.Migrations
{
    public partial class DataModelsCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Category identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                },
                comment: "Categories table");

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Manufacturer identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Manufacturer name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                },
                comment: "Manufacturers table");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Order identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Order date"),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Customer identifier"),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Total order amount")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                },
                comment: "Orders table");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Product identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "Product name"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Product description"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Product price"),
                    StockQuantity = table.Column<int>(type: "int", nullable: false, comment: "Quantity in stock"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Product image"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates whether the product is deleted"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier"),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false, comment: "Manufacturer identifier"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Category identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Products table");

            migrationBuilder.CreateTable(
                name: "OrdersDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false, comment: "Order identifier"),
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Product identifier"),
                    OrderDetailId = table.Column<int>(type: "int", nullable: false, comment: "Order detail identifier"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Quantity of the product in the order"),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Unit price of the product in the order")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrdersDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdersDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "OrdersDetails table");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetails_ProductId",
                table: "OrdersDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufacturerId",
                table: "Products",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId",
                table: "Products",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
