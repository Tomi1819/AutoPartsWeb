namespace AutoPartsWeb.Core.Contracts
{
    using AutoPartsWeb.Core.Models.Home;

    public interface IProductService
    {
        Task<IEnumerable<ProductIndexViewModel>> GetAllProductsAsync();
        Task<IEnumerable<ProductSearchViewModel>> SearchProductsAsync(string keywords);
        Task<IEnumerable<ProductIndexViewModel>> FilterProductsAsync(string category, string manufacturer, decimal minPrice, decimal maxPrice);
        Task<IEnumerable<ProductIndexViewModel>> GetSpecialOffersAsync();
    }
}
