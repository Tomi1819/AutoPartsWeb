﻿// <auto-generated />
using System;
using AutoPartsWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoPartsWeb.Data.Migrations
{
    [DbContext(typeof(AutoPartsWebDbContext))]
    [Migration("20240407094524_ExtendedUserColumns")]
    partial class ExtendedUserColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dea12856-c198-4129-b3f3-b893d8395082",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "615b9597-55fd-418f-8166-afa1242e6cdd",
                            Email = "admint@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Jacob",
                            LastName = "Lugo",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@mail.com",
                            NormalizedUserName = "admint@mail.com",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5b944f6f-f943-44d5-ba68-57985fa48c29",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        },
                        new
                        {
                            Id = "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f1eb938d-623e-4b9b-bc54-7742727213c9",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Davis",
                            LastName = "Pope",
                            LockoutEnabled = false,
                            NormalizedEmail = "guest@mail.com",
                            NormalizedUserName = "guest@mail.com",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "57be7de0-9cb1-4ca9-b609-16490a12b955",
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com"
                        });
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Category identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicates whether the category is deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Category name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasComment("Categories table");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Engine"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Suspension"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Brakes"
                        });
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Dealer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Dealer identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Comapany name");

                    b.Property<string>("CompanyNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasComment("Comapany number");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Dealer description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Dealer name");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("User identifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Dealers");

                    b.HasComment("Dealers table");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "AutoTrader",
                            CompanyNumber = "7516425943",
                            Description = "The biggest auto parts dealer in Bulgaria.",
                            IsDeleted = false,
                            Name = "Dimitrichko",
                            UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                        });
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Manufacturer identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("Manufacturer country");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicates whether the manufacturer is deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Manufacturer name");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");

                    b.HasComment("Manufacturers table");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Country = "Italy",
                            IsDeleted = false,
                            Name = "Brembo"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Germany",
                            IsDeleted = false,
                            Name = "Bilstein"
                        },
                        new
                        {
                            Id = 1,
                            Country = "Germany",
                            IsDeleted = false,
                            Name = "Bosh"
                        });
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Order identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DealerId")
                        .HasColumnType("int")
                        .HasComment("Dealer identifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2")
                        .HasComment("Order date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Status of order");

                    b.HasKey("Id");

                    b.HasIndex("DealerId");

                    b.ToTable("Orders");

                    b.HasComment("Orders table");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DealerId = 1,
                            OrderDate = new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "In progress"
                        });
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasComment("Order identifier");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasComment("Product identifier");

                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasComment("Order detail identifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Unit price of the product in the order");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasComment("Quantity of the product in the order");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrdersDetails");

                    b.HasComment("OrdersDetails table");
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Product identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasComment("Category identifier");

                    b.Property<int>("DealerId")
                        .HasColumnType("int")
                        .HasComment("Dealer identifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Product description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Product image");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicates whether the product is deleted");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int")
                        .HasComment("Manufacturer identifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasComment("Product name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Product price");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int")
                        .HasComment("Quantity in stock");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("User identifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DealerId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");

                    b.HasComment("Products table");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DealerId = 1,
                            Description = "An automotive battery, or car battery, is a rechargeable battery that is used to start a motor vehicle.",
                            ImageUrl = "https://cdn.media.halfords.com/i/washford/950295/Halfords-HB063-Lead-Acid-12V-Car-Battery-3-Year-Guarantee?fmt=auto&qlt=default&$sfcc_tile$&w=680",
                            IsDeleted = false,
                            ManufacturerId = 1,
                            Name = "Battery",
                            Price = 120.00m,
                            StockQuantity = 15,
                            UserId = "5e84f853-e25f-4a90-8f2b-448ffdeed35e"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            DealerId = 1,
                            Description = "BILSTEIN EVO T2 track performance suspension.",
                            ImageUrl = "https://performance.bilstein.com/wp-content/uploads/2023/10/BILSTEIN-EVO-T2.png",
                            IsDeleted = false,
                            ManufacturerId = 2,
                            Name = "BilsteinEvoT2",
                            Price = 250.00m,
                            StockQuantity = 5,
                            UserId = "5e84f853-e25f-4a90-8f2b-448ffdeed35e"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            DealerId = 1,
                            Description = "Brake pads convert the kinetic energy of a vehicle to thermal energy through friction. Two brake pads are contained in the brake with their friction surfaces facing the rotor.",
                            ImageUrl = "https://www.buybrakes.com/images/product/brembo-oe-replacement-brake-pads.jpg",
                            IsDeleted = false,
                            ManufacturerId = 3,
                            Name = "Brake pads",
                            Price = 55.00m,
                            StockQuantity = 30,
                            UserId = "5e84f853-e25f-4a90-8f2b-448ffdeed35e"
                        });
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Rating identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasComment("Product identifier");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("User identifier");

                    b.Property<int>("Value")
                        .HasColumnType("int")
                        .HasComment("Ratings value");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");

                    b.HasComment("Ratings table");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductId = 3,
                            UserId = "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                            Value = 4
                        },
                        new
                        {
                            Id = 2,
                            ProductId = 1,
                            UserId = "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                            Value = 5
                        },
                        new
                        {
                            Id = 3,
                            ProductId = 2,
                            UserId = "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                            Value = 5
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Dealer", b =>
                {
                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Order", b =>
                {
                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.Dealer", "Dealer")
                        .WithMany("Orders")
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dealer");
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.Order", "Order")
                        .WithMany("OrdersDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.Product", "Product")
                        .WithMany("OrdersDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Product", b =>
                {
                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.Dealer", "Dealer")
                        .WithMany("Products")
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Dealer");

                    b.Navigation("Manufacturer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Rating", b =>
                {
                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AutoPartsWeb.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Dealer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Manufacturer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Order", b =>
                {
                    b.Navigation("OrdersDetails");
                });

            modelBuilder.Entity("AutoPartsWeb.Infrastructure.Data.Models.Product", b =>
                {
                    b.Navigation("OrdersDetails");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
