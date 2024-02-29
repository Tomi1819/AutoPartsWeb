namespace AutoPartsWeb.Infrastructure.Data.DataSeed
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        private readonly DataSeeder dataSeeder;

        public UserConfiguration(DataSeeder dataSeeder)
        {
            this.dataSeeder = dataSeeder;
        }
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(new IdentityUser[]
            {
                dataSeeder.AdminUser,
                dataSeeder.GuestUser
            });
        }
    }
}
