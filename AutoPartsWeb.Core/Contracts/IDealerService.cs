namespace AutoPartsWeb.Core.Contracts
{
    using AutoPartsWeb.Core.Models.Dealer;

    public interface IDealerService
    {
        Task<bool> ExistsByIdAsync(string userId);
        Task<bool> NecessaryRequirementsAsync(DealerFormViewModel model);
        Task<bool> CreateDealerAsync(DealerFormViewModel model);
        Task<int?> GetDealerIdAsync(string userId);
    }
}
