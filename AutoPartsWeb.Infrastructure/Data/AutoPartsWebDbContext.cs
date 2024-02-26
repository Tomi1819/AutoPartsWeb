namespace AutoPartsWeb.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class AutoPartsWebDbContext : IdentityDbContext
    {
        public AutoPartsWebDbContext(DbContextOptions<AutoPartsWebDbContext> options)
            : base(options)
        {
        }
    }
}
