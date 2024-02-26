namespace AutoPartsWeb.Data
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class AutoPartsWebDbContext : IdentityDbContext
    {
        public AutoPartsWebDbContext(DbContextOptions<AutoPartsWebDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderId, od.ProductId });

            builder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrdersDetails)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrdersDetails)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }

        public DbSet<OrderDetail> OrdersDetails { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
    }
}
