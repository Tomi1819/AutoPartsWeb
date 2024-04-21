namespace AutoPartsWeb.Core.Services
{
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Category;
    using AutoPartsWeb.Infrastructure.Data.Common;
    using AutoPartsWeb.Infrastructure.Data.Models;
    using System.Threading.Tasks;

    public class CategoryService : ICategoryService
    {
        private readonly IRepository repository;

        public CategoryService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddCategoryAsync(CategoryFormViewModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var category = new Category()
            {
                Id = model.Id,
                Name = model.Name,
            };

            await repository.AddAsync(category);
            await repository.SaveChangesAsync();
        }

        public async Task RemoveCategoryAsync(int categoryId)
        {
            var category = await repository.GetByIdAsync<Category>(categoryId);

            if (category == null)
            {
                throw new ArgumentNullException(nameof(categoryId), "Category not found!");
            }

            category.IsDeleted = true;
            await repository.SaveChangesAsync();
        }
    }
}
