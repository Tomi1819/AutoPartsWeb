namespace AutoPartsWeb.Controllers
{
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Category;
    using Microsoft.AspNetCore.Mvc;

    public class CategoryController : BaseController
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CategoryFormViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await categoryService.AddCategoryAsync(model);
            return RedirectToAction("Index", "Home");
        }
    }
}
