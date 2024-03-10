namespace AutoPartsWeb.Core.Contracts
{
    using AutoPartsWeb.Core.Models.Home;

    public interface IProductService
    {
        Task<IEnumerable<ProductIndexServiceModel>> GetAllProductsAsync();
        Task<IEnumerable<ProductIndexServiceModel>> SearchProductsAsync(string keywords);
        Task<IEnumerable<ProductIndexServiceModel>> FilterProductsAsync(string category, string manufacturer, decimal minPrice, decimal maxPrice);
        Task<IEnumerable<ProductIndexServiceModel>> GetSpecialOffersAsync();
    }
}
