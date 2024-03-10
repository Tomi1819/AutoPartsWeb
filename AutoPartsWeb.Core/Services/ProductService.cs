namespace AutoPartsWeb.Core.Services
{
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Home;

    public class ProductService : IProductService
    {
        public Task<IEnumerable<ProductIndexServiceModel>> FilterProductsAsync(string category, string manufacturer, decimal minPrice, decimal maxPrice)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductIndexServiceModel>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductIndexServiceModel>> GetSpecialOffersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductIndexServiceModel>> SearchProductsAsync(string keywords)
        {
            throw new NotImplementedException();
        }
    }
}
