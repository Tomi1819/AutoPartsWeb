namespace AutoPartsWeb.Core.Services
{
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Home;
    using AutoPartsWeb.Core.Models.Product;
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

        public async Task<IEnumerable<ProductIndexViewModel>> GetAllProductsAsync()
        {
            return await repository
                .AllReadOnly<Product>()
                .Select(p => new ProductIndexViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                })
                .ToListAsync();
        }

        public async Task<ProductDetailsViewModel> GetProductByIdAsync(int id)
        {
            var product = await repository
                .AllReadOnly<Product>()
                .Where(p => p.Id == id)
                .Select(p => new ProductDetailsViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                    Quantity = p.StockQuantity,
                    Rating = p.Ratings.Any() ? p.Ratings.Average(r => r.Value) : 0,
                    ManufacturerName = p.Manufacturer.Name,
                    CategoryName = p.Category.Name
                })
                .FirstOrDefaultAsync();

            return product;
        }

        public async Task<IEnumerable<ProductSearchViewModel>> SearchProductsAsync(string keywords)
        {
            if (string.IsNullOrWhiteSpace(keywords))
            {
                return Enumerable.Empty<ProductSearchViewModel>();
            }

            keywords = keywords.ToLower();

            var products = await repository
                .AllReadOnly<Product>()
                .Include(p => p.Manufacturer)
                .Include(p => p.Category)
                .Where(p => p.Name.ToLower().Contains(keywords) || p.Description.ToLower().Contains(keywords))
                .ToListAsync();

            var productModels = products
                .Select(p => new ProductSearchViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                    ManufacturerName = p.Manufacturer.Name,
                    CategoryName = p.Category.Name
                });

            return productModels;
        }
    }
}
