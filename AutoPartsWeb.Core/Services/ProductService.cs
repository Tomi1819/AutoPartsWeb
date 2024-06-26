﻿namespace AutoPartsWeb.Core.Services
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

        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
            return await repository.AllReadOnly<Category>()
                .Where(c => c.IsDeleted == false)
                .AnyAsync(c => c.Id == categoryId);
        }

        public async Task<int> CreateAsync(ProductFormViewModel model, int dealerId)
        {
            var dealer = await repository.AllReadOnly<Dealer>()
                .FirstOrDefaultAsync(d => d.Id == dealerId);

            if (dealer == null)
            {
                throw new ArgumentException("Dealer with the provided ID does not exist.");
            }

            var product = new Product
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                StockQuantity = model.Quantity,
                ImageUrl = model.ImageUrl,
                CategoryId = model.CategoryId,
                ManufacturerId = model.ManufacturerId,
                DealerId = dealerId,
                UserId = dealer.UserId
            };

            var rating = new Rating()
            {
                ProductId = product.Id,
                UserId = product.UserId,
                Value = model.Rating
            };

            product.Ratings.Add(rating);

            await repository.AddAsync(product);
            await repository.SaveChangesAsync();

            return product.Id;
        }

        public async Task DeleteProductAsync(int productId)
        {
            var product = await repository.GetByIdAsync<Product>(productId);

            if (product != null && product.IsDeleted == false)
            {
                product.IsDeleted = true;
                await repository.SaveChangesAsync();
            }
        }

        public async Task EditProductAsync(ProductFormViewModel model, int productId)
        {
            var productToEdit = await repository
                .All<Product>()
                .Where(p => p.IsDeleted == false)
                .FirstOrDefaultAsync (d => d.Id == productId);

            if (productToEdit != null)
            {
                productToEdit.Name = model.Name;
                productToEdit.Description = model.Description;
                productToEdit.Price = model.Price;
                productToEdit.StockQuantity = model.Quantity;
                productToEdit.ManufacturerId = model.ManufacturerId;
                productToEdit.CategoryId = model.CategoryId;
            }

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<AllCategoriesViewModel>> GetAllCategoriesAsync()
        {
            return await repository.AllReadOnly<Category>()
                .Where(c => c.IsDeleted == false)
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
                .Where(m => m.IsDeleted == false)
                .Select(m => new AllManufacturersViewModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    Country = m.Country
                })
                .ToListAsync();
        }

        public async Task<AllProductsViewModel> GetAllProductsAsync(int pageNumber, int pageSize)
        {
            var totalParts = await repository
                .AllReadOnly<Product>()
                .Where(p => p.IsDeleted == false)
                .CountAsync();

            var totalPages = (int)Math.Ceiling(totalParts / (double)pageSize);
            var currentPage = Math.Max(1, Math.Min(pageNumber, totalPages));

            var products = await repository.AllReadOnly<Product>()
                .Where (p => p.IsDeleted == false)
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new ProductIndexViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl
                })
                .ToListAsync();

            return new AllProductsViewModel
            {
                Products = products,
                PageNumber = currentPage,
                PageSize = pageSize,
                TotalPages = totalPages
            };
        }

        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await repository.GetByIdAsync<Category>(id);
        }

        public async Task<Manufacturer?> GetManufacturerAsync(int id)
        {
            return await repository.GetByIdAsync<Manufacturer>(id);
        }

        public async Task<ProductFormViewModel> GetProductByIdAsync(int id)
        {
            var product = await repository
                .AllReadOnly<Product>()
                .Where(p => p.Id == id && p.IsDeleted == false)
                .Select(p => new ProductFormViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                    Quantity = p.StockQuantity,
                    Rating = p.Ratings.Any() ? (int)p.Ratings.Average(r => r.Value) : 0,
                    UserId = p.UserId,
                    ManufacturerName = p.Manufacturer.Name,
                    CategoryName = p.Category.Name
                })
                .FirstOrDefaultAsync();

            return product;
        }

        public async Task<bool> ManufacturerExistAsync(int manufacturerId)
        {
            return await repository.AllReadOnly<Manufacturer>()
                .Where(m => m.IsDeleted == false)
                .AnyAsync(m => m.Id == manufacturerId);
        }

        public async Task<bool> ProductExistsAsync(int productId)
        {
            return await repository
                .AllReadOnly<Product>()
                .AnyAsync(p => p.Id == productId);
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
