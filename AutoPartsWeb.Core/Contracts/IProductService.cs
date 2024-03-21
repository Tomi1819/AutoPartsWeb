namespace AutoPartsWeb.Core.Contracts
{
    using AutoPartsWeb.Core.Models.Home;
    using AutoPartsWeb.Core.Models.Product;

    public interface IProductService
    {
        Task<IEnumerable<ProductIndexViewModel>> GetAllProductsAsync();
        Task<IEnumerable<ProductSearchViewModel>> SearchProductsAsync(string keywords);
        Task<ProductDetailsViewModel> GetProductByIdAsync(int id);
    }
}
