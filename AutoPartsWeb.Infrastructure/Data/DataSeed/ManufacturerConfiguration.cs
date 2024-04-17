namespace AutoPartsWeb.Infrastructure.Data.DataSeed
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        private readonly DataSeeder dataSeeder;

        public ManufacturerConfiguration(DataSeeder dataSeeder)
        {
            this.dataSeeder = dataSeeder;
        }
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.HasData(new Manufacturer[]
            {
                dataSeeder.Brembo,
                dataSeeder.Bilstein,
                dataSeeder.Bosch,
                dataSeeder.Osram
            });
        }
    }
}
