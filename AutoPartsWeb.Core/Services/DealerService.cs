namespace AutoPartsWeb.Core.Services
{
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Dealer;
    using AutoPartsWeb.Infrastructure.Data.Common;
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class DealerService : IDealerService
    {
        private readonly IRepository repository;
        public DealerService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Dealer>()
                .AnyAsync(d => d.UserId == userId);
        }

        public async Task<int?> GetDealerIdAsync(string userId)
        {
            return (await repository.AllReadOnly<Dealer>()
                 .FirstOrDefaultAsync(d => d.UserId == userId))?.Id;
        }

        public async Task<bool> NecessaryRequirementsAsync(DealerFormViewModel model)
        {
            return await repository.AllReadOnly<Dealer>()
                .AnyAsync(d => d.CompanyName == model.CompanyName &&
                d.CompanyNumber == model.CompanyNumber &&
                d.Name == model.Name);
        }
        public async Task CreateDealerAsync(DealerFormViewModel model)
        {
            await repository.AddAsync(new Dealer()
            {
                Name = model.Name,
                CompanyName = model.CompanyName,
                CompanyNumber = model.CompanyNumber,
                UserId = model.UserId,
            });

            await repository.SaveChangesAsync();
        }
    }
}
