namespace AutoPartsWeb.Data
{
    using AutoPartsWeb.Infrastructure.Data.DataSeed;
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class AutoPartsWebDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly DataSeeder dataSeeder;
        public AutoPartsWebDbContext(DbContextOptions<AutoPartsWebDbContext> options)
            : base(options)
        {
            dataSeeder = new DataSeeder();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new OrderDetailConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration(dataSeeder));
            builder.ApplyConfiguration(new ManufacturerConfiguration(dataSeeder));
            builder.ApplyConfiguration(new ProductConfiguration(dataSeeder));
            builder.ApplyConfiguration(new UserConfiguration(dataSeeder));
            builder.ApplyConfiguration(new RatingConfiguration(dataSeeder));
            builder.ApplyConfiguration(new OrderConfiguration(dataSeeder));
            builder.ApplyConfiguration(new DealerConfiguration(dataSeeder));
            builder.ApplyConfiguration(new UserClaimsConfiguration(dataSeeder));

            base.OnModelCreating(builder);
        }

        public DbSet<OrderDetail> OrdersDetails { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Rating> Ratings { get; set; } = null!;
        public DbSet<Dealer> Dealers { get; set; } = null!;
    }
}
