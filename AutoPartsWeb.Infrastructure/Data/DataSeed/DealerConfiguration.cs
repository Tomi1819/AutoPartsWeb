namespace AutoPartsWeb.Infrastructure.Data.DataSeed
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class DealerConfiguration : IEntityTypeConfiguration<Dealer>
    {
        private readonly DataSeeder dataSeeder;

        public DealerConfiguration(DataSeeder dataSeeder)
        {
            this.dataSeeder = dataSeeder;
        }
        public void Configure(EntityTypeBuilder<Dealer> builder)
        {
            builder.HasData(new Dealer[]
            {
                dataSeeder.Dealer
            });
        }
    }
}
