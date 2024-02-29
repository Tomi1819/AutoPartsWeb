namespace AutoPartsWeb.Infrastructure.Data.DataSeed
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder
                .HasKey(od => new { od.OrderId, od.ProductId });

            builder
                .HasOne(od => od.Order)
                .WithMany(o => o.OrdersDetails)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(od => od.Product)
                .WithMany(p => p.OrdersDetails)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
