namespace AutoPartsWeb.Infrastructure.Data.DataSeed
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        private readonly DataSeeder dataSeeder;

        public OrderConfiguration(DataSeeder dataSeeder)
        {
            this.dataSeeder = dataSeeder;
        }

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(new Order[]
            {
                dataSeeder.Order
            });
        }
    }
}
