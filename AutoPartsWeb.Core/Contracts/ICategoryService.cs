namespace AutoPartsWeb.Core.Contracts
{
    using AutoPartsWeb.Core.Models.Category;

    public interface ICategoryService
    {
        Task AddCategoryAsync(CategoryFormViewModel model);
        Task RemoveCategoryAsync(int categoryId);
    }
}
