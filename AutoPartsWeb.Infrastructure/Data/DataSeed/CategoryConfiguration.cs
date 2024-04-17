namespace AutoPartsWeb.Infrastructure.Data.DataSeed
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        private readonly DataSeeder dataSeeder;

        public CategoryConfiguration(DataSeeder dataSeeder)
        {
            this.dataSeeder = dataSeeder;
        }
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category[]
            {
                dataSeeder.EngineCategory,
                dataSeeder.SuspensionCategory,
                dataSeeder.BrakesCategory,
                dataSeeder.ExteriorCategory
            });
        }
    }
}
