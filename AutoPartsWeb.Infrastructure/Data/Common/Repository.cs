namespace AutoPartsWeb.Infrastructure.Data.Common
{
    using AutoPartsWeb.Data;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class Repository : IRepository
    {
        private readonly DbContext context;

        public Repository(AutoPartsWebDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
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

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        private DbSet<T> DbSet<T>() where T : class
        {
            return context.Set<T>();
        }
    }
}
