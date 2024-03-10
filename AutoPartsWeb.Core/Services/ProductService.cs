namespace AutoPartsWeb.Core.Services
{
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Home;
    using AutoPartsWeb.Infrastructure.Data.Common;
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ProductService : IProductService
    {
        private readonly IRepository repository;

        public ProductService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<ProductIndexServiceModel>> GetAllProductsAsync()
        {
            return await repository
                .AllReadOnly<Product>()
                .Select(p => new ProductIndexServiceModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                    ManufacturerName = p.Manufacturer.Name,
                    CategoryName = p.Category.Name
                })
                .ToListAsync();
        }
        public Task<IEnumerable<ProductIndexServiceModel>> FilterProductsAsync(string category, string manufacturer, decimal minPrice, decimal maxPrice)
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
