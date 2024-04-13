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

        public async Task<int> CreateAsync(ProductFormViewModel model, int dealerId)
        {
            var product = new Product()
            {
                Id = model.Id,
                Name = model.Title,
                Description = model.Description,
                Price = model.Price,
                StockQuantity = model.Quantity,
                ImageUrl = model.ImageUrl,
                CategoryId = model.CategoryId,
                ManufacturerId = model.ManufacturerId,
                DealerId = dealerId,
            };

            await repository.AddAsync(product);
            await repository.SaveChangesAsync();

            return product.Id;
        }

        public async Task<IEnumerable<AllCategoriesViewModel>> GetAllCategoriesAsync()
        {
            return await repository.AllReadOnly<Category>()
                .Select(c => new AllCategoriesViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<AllManufacturersViewModel>> GetAllManufacturersAsync()
        {
            return await repository.AllReadOnly<Manufacturer>()
                .Select(m => new AllManufacturersViewModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ProductIndexViewModel>> GetAllProductsAsync()
        {
            return await repository
                .AllReadOnly<Product>()
                .Where(p => p.IsDeleted == false)
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
                .Where(p => p.Id == id && p.IsDeleted == false)
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
                .Where(p => p.Name.ToLower().Contains(keywords) || 
                p.Description.ToLower().Contains(keywords) &&
                p.IsDeleted == false)
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
