namespace AutoPartsWeb.Core.Contracts
{
    using AutoPartsWeb.Core.Models.Home;
    using AutoPartsWeb.Core.Models.Product;
    using AutoPartsWeb.Infrastructure.Data.Models;

    public interface IProductService
    {
        Task<AllProductsViewModel> GetAllProductsAsync(int pageNumber, int pageSize);
        Task<IEnumerable<ProductSearchViewModel>> SearchProductsAsync(string keywords);
        Task<ProductFormViewModel> GetProductByIdAsync(int id);
        Task<IEnumerable<AllCategoriesViewModel>> GetAllCategoriesAsync();
        Task<IEnumerable<AllManufacturersViewModel>> GetAllManufacturersAsync();
        Task<int> CreateAsync(ProductFormViewModel model, int dealerId);
        Task<bool> CategoryExistsAsync(int categoryId);
        Task<bool> ManufacturerExistAsync(int manufacturerId);
        Task EditProductAsync(ProductFormViewModel model, int productId);
        Task<bool> ProductExistsAsync(int productId);
        Task DeleteProductAsync(int productId);
        Task<Category?> GetCategoryByIdAsync(int id);
        Task<Manufacturer?> GetManufacturerAsync(int id);
    }
}
