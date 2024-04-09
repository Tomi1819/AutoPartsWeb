using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsWeb.Infrastructure.Data.DataSeed
{
    internal class UserClaimsConfiguration : IEntityTypeConfiguration<IdentityUserClaim<string>>
    {
        private readonly DataSeeder dataSeeder;

        public UserClaimsConfiguration(DataSeeder dataSeeder)
        {
            this.dataSeeder = dataSeeder;
        }

        public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder)
        {
            builder.HasData(dataSeeder.GuestUserClaim, dataSeeder.AdminUserClaim);
        }
    }
}
