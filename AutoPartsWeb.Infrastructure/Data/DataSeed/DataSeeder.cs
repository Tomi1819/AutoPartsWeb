using AutoPartsWeb.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using static AutoPartsWeb.Infrastructure.DataConstants.CustomClaims;

namespace AutoPartsWeb.Infrastructure.Data.DataSeed
{
    public class DataSeeder
    {
        public ApplicationUser AdminUser { get; set; }
        public ApplicationUser GuestUser { get; set; }
        public ApplicationUser DealerUser { get; set; }

        public IdentityUserClaim<string> AdminUserClaim { get; set; }
        public IdentityUserClaim<string> GuestUserClaim { get; set; }
        public IdentityUserClaim<string> DealerUserClaim { get; set; }

        public Dealer Dealer { get; set; }
        public Dealer AdminDealer { get; set; }

        public Category EngineCategory { get; set; }
        public Category BrakesCategory { get; set; }
        public Category SuspensionCategory { get; set; }

        public Manufacturer Bosch { get; set; }
        public Manufacturer Bilstein { get; set; }
        public Manufacturer Brembo { get; set; }

        public Product Battery { get; set; }
        public Product BilsteinEvoT2 { get; set; }
        public Product BrakePads { get; set; }

        public Rating First { get; set; }
        public Rating Second { get; set; }
        public Rating Third { get; set; }

        public Order Order { get; set; }

        public DataSeeder()
        {
            SeedUsers();
            SeedDealers();
            SeedCategories();
            SeedManufacturers();
            SeedProducts();
            SeedRatings();
            SeedOrders();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            DealerUser = new ApplicationUser()
            {
                Id = "1a558517-6bd0-4da4-9a6c-e5d92df0a945",
                UserName = "dealer@mail.com",
                NormalizedUserName = "dealer@mail.com",
                Email = "dealer@mail.com",
                NormalizedEmail = "dealer@mail.com",
                FirstName = "Jake",
                LastName = "Paul"
            };

            DealerUserClaim = new IdentityUserClaim<string>()
            {
                Id = 4,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Jake Paul",
                UserId = "1a558517-6bd0-4da4-9a6c-e5d92df0a945"
            };

            DealerUser.PasswordHash = hasher.HashPassword(DealerUser, "azsumdealer");

            AdminUser = new ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "admin@mail.com",
                NormalizedUserName = "admin@mail.com",
                Email = "admint@mail.com",
                NormalizedEmail = "admin@mail.com",
                FirstName = "Jacob",
                LastName = "Lugo"
            };

            AdminUserClaim = new IdentityUserClaim<string>()
            {
                Id = 1,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Jacob Lugo",
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            };

            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "azsumadmin");

            GuestUser = new ApplicationUser()
            {
                Id = "5e84f853-e25f-4a90-8f2b-448ffdeed35e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com",
                FirstName = "Davis",
                LastName = "Pope"
            };

            GuestUserClaim = new IdentityUserClaim<string>()
            {
                Id = 2,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Davis Pope",
                UserId = "5e84f853-e25f-4a90-8f2b-448ffdeed35e"
            };

            GuestUser.PasswordHash = hasher.HashPassword(GuestUser, "azsumguest");

        }
        private void SeedDealers()
        {
            Dealer = new Dealer()
            {
                Id = 1,
                Name = "Dimitrichko",
                CompanyName = "AutoTrader",
                CompanyNumber = "7516425943",
                Description = "The biggest auto parts dealer in Bulgaria.",
                IsDeleted = false,
                UserId = DealerUser.Id
            };

            AdminDealer = new Dealer()
            {
                Id = 2,
                Name = "Admin",
                CompanyName = "AdminHouse",
                CompanyNumber = "5212222222",
                Description = "Nothing special about description.",
                IsDeleted = false,
                UserId = AdminUser.Id
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

        private void SeedOrders()
        {
            Order = new Order()
            {
                Id = 1,
                OrderDate = new DateTime(2024, 3, 21),
                Status = "In progress",
                DealerId = Dealer.Id,
            };
        }
        private void SeedManufacturers()
        {
            Bosch = new Manufacturer()
            {
                Id = 1,
                Name = "Bosch",
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
                ManufacturerId = Bosch.Id,
                CategoryId = EngineCategory.Id,
                DealerId = Dealer.Id,
            };

            BilsteinEvoT2 = new Product()
            {
                Id = 2,
                Name = "BilsteinEvoT2",
                Description = "BILSTEIN EVO T2 track performance, a winning combination of BILSTEIN monotube technology and ST suspensions coilovers.",
                Price = 899.99m,
                StockQuantity = 5,
                ImageUrl = "https://www.buybrakes.com/images/product/bilstein-6112-suspension-kit.jpg",
                IsDeleted = false,
                UserId = GuestUser.Id,
                ManufacturerId = Bilstein.Id,
                CategoryId = SuspensionCategory.Id,
                DealerId = Dealer.Id,
            };

            BrakePads = new Product()
            {
                Id = 3,
                Name = "Brake Pads",
                Description = "A brake pad is a component of disc brakes, used in automotive and other applications.",
                Price = 65.00m,
                StockQuantity = 20,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQQZ_AsODk3OKfTO8mqm9ZHU56YW5KL0ovBXFdmipZvg&s",
                IsDeleted = false,
                UserId = DealerUser.Id,
                ManufacturerId = Brembo.Id,
                CategoryId = BrakesCategory.Id,
                DealerId = Dealer.Id,
            };
        }

        private void SeedRatings()
        {
            First = new Rating()
            {
                Id = 1,
                Value = 5,
                ProductId = Battery.Id,
                UserId = GuestUser.Id
            };

            Second = new Rating()
            {
                Id = 2,
                Value = 4,
                ProductId = BilsteinEvoT2.Id,
                UserId = AdminUser.Id
            };

            Third = new Rating()
            {
                Id = 3,
                Value = 5,
                ProductId = BrakePads.Id,
                UserId = DealerUser.Id
            };
        }
    }
}
