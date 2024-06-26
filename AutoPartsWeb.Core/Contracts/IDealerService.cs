﻿namespace AutoPartsWeb.Core.Contracts
{
    using AutoPartsWeb.Core.Models.Dealer;

    public interface IDealerService
    {
        Task<bool> ExistsByIdAsync(string userId);
        Task<bool> HasNecessaryRequirementsAsync(DealerFormViewModel model);
        Task CreateDealerAsync(DealerFormViewModel model);
        Task<int?> GetDealerIdAsync(string userId);
    }
}
