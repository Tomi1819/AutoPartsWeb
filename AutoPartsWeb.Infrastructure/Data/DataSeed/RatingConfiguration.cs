namespace AutoPartsWeb.Infrastructure.Data.DataSeed
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        private readonly DataSeeder dataSeeder;

        public RatingConfiguration(DataSeeder dataSeeder)
        {
            this.dataSeeder = dataSeeder;
        }
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder
                .HasOne(r => r.Product)
                .WithMany(p => p.Ratings)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new Rating[]
            {
                dataSeeder.First,
                dataSeeder.Second,
                dataSeeder.Third,
                dataSeeder.Forth,
                dataSeeder.Fifth,
                dataSeeder.Sixth,
                dataSeeder.Seventh
            });
        }
    }
}
