namespace AutoPartsWeb.Infrastructure.Data.Common
{
    using AutoPartsWeb.Data;
    using Microsoft.EntityFrameworkCore;

    public class Repository : IRepository
    {
        private readonly DbContext context;

        public Repository(AutoPartsWebDbContext context)
        {
            this.context = context;
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return DbSet<T>()
                .AsNoTracking();
        }

        private DbSet<T> DbSet<T>() where T : class
        {
            return context.Set<T>();
        }
    }
}
