namespace AutoPartsWeb.Infrastructure.Data.DataSeed
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        private readonly DataSeeder dataSeeder;

        public ProductConfiguration(DataSeeder dataSeeder)
        {
            this.dataSeeder = dataSeeder;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasOne(p => p.Dealer)
                .WithMany(d => d.Products)
                .HasForeignKey(p => p.DealerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new Product[]
            {
                dataSeeder.Battery,
                dataSeeder.BilsteinEvoT2,
                dataSeeder.BrakePads,
                dataSeeder.TimingBelt,
                dataSeeder.BrakeDisc,
                dataSeeder.XenarcBulb,
                dataSeeder.WindshieldWipers
            });
        }
    }
}
