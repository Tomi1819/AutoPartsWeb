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

        public Task<bool> CreateDealerAsync(DealerFormViewModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Dealer>()
                .AnyAsync(d => d.UserId == userId);
        }

        public Task<int?> GetDealerIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NecessaryRequirementsAsync(DealerFormViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
