namespace AutoPartsWeb.Core.Contracts
{
    using AutoPartsWeb.Core.Models.Home;

    public interface IProductService
    {
        Task<IEnumerable<ProductIndexViewModel>> GetAllProductsAsync();
        Task<IEnumerable<ProductSearchViewModel>> SearchProductsAsync(string keywords);
    }
}
