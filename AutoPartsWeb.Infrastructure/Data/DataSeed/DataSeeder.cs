namespace AutoPartsWeb.Infrastructure.Data.DataSeed
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity;

    public class DataSeeder
    {
        public IdentityUser AdminUser { get; set; } = null!;
        public IdentityUser GuestUser { get; set; } = null!;

        public Category EngineCategory { get; set; } = null!;
        public Category BrakesCategory { get; set; } = null!;
        public Category SuspensionCategory { get; set; } = null!;

        public Manufacturer Bosh { get; set; } = null!;
        public Manufacturer Bilstein { get; set; } = null!;
        public Manufacturer Brembo { get; set; } = null!;

        public Product Battery { get; set; } = null!;
        public Product BilsteinEvoT2 { get; set; } = null!;
        public Product BrakePads { get; set; } = null!;

        public Rating First { get; set; } = null!;
        public Rating Second { get; set; } = null!;
        public Rating Third { get; set; } = null!;

        public DataSeeder()
        {
            SeedUsers();
            SeedCategories();
            SeedManufacturers();
            SeedProducts();
            SeedRatings();
        }

        private void SeedUsers()
        {
            AdminUser = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "admin@mail.com",
                NormalizedUserName = "admint@mail.com",
                Email = "admint@mail.com",
                NormalizedEmail = "admin@mail.com"
            };

            GuestUser = new IdentityUser()
            {
                Id = "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };
        }
        private void SeedCategories()
        {
            EngineCategory = new Category()
            {
                Id = 1,
                Name = "Engine",
                IsDeleted = false,
            };

            BrakesCategory = new Category()
            {
                Id = 2,
                Name = "Brakes",
                IsDeleted = false,
            };

            SuspensionCategory = new Category()
            {
                Id = 3,
                Name = "Suspension",
                IsDeleted = false,
            };
        }

        private void SeedManufacturers()
        {
            Bosh = new Manufacturer()
            {
                Id = 1,
                Name = "Bosh",
                Country = "Germany",
                IsDeleted = false
            };

            Bilstein = new Manufacturer()
            {
                Id = 2,
                Name = "Bilstein",
                Country = "Germany",
                IsDeleted = false,
            };

            Brembo = new Manufacturer()
            {
                Id = 3,
                Name = "Brembo",
                Country = "Italy",
                IsDeleted = false
            };
        }

        private void SeedProducts()
        {
            Battery = new Product()
            {
                Id = 1,
                Name = "Battery",
                Description = "An automotive battery, or car battery, is a rechargeable battery that is used to start a motor vehicle.",
                Price = 120.00m,
                StockQuantity = 15,
                ImageUrl = "https://cdn.media.halfords.com/i/washford/950295/Halfords-HB063-Lead-Acid-12V-Car-Battery-3-Year-Guarantee?fmt=auto&qlt=default&$sfcc_tile$&w=680",
                IsDeleted = false,
                UserId = GuestUser.Id,
                ManufacturerId = Bosh.Id,
                CategoryId = EngineCategory.Id
            };

            BilsteinEvoT2 = new Product()
            {
                Id = 2,
                Name = "BilsteinEvoT2",
                Description = "BILSTEIN EVO T2 track performance suspension.",
                Price = 250.00m,
                StockQuantity = 5,
                ImageUrl = "https://performance.bilstein.com/wp-content/uploads/2023/10/BILSTEIN-EVO-T2.png",
                IsDeleted = false,
                UserId = GuestUser.Id,
                ManufacturerId = Bilstein.Id,
                CategoryId = SuspensionCategory.Id
            };

            BrakePads = new Product()
            {
                Id = 3,
                Name = "Brake pads",
                Description = "Brake pads convert the kinetic energy of a vehicle to thermal energy through friction. Two brake pads are contained in the brake with their friction surfaces facing the rotor.",
                Price = 55.00m,
                StockQuantity = 30,
                ImageUrl = "https://www.buybrakes.com/images/product/brembo-oe-replacement-brake-pads.jpg",
                IsDeleted = false,
                UserId = GuestUser.Id,
                ManufacturerId = Brembo.Id,
                CategoryId = BrakesCategory.Id
            };
        }

        private void SeedRatings()
        {
            First = new Rating()
            {
                Id = 1,
                Value = 4,
                ProductId = 3,
                UserId = GuestUser.Id,
            };

            Second = new Rating()
            {
                Id = 2,
                Value = 5,
                ProductId = 1,
                UserId = GuestUser.Id,
            };

            Third = new Rating()
            {
                Id = 3,
                Value = 5,
                ProductId = 2,
                UserId = GuestUser.Id,
            };
        }
    }
}
