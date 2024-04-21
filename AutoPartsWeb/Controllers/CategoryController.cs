namespace AutoPartsWeb.Controllers
{
    using AutoPartsWeb.Attributes;
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Category;
    using Microsoft.AspNetCore.Mvc;

    public class CategoryController : BaseController
    {
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;

        public CategoryController(ICategoryService categoryService,
            IProductService productService)
        {
            this.categoryService = categoryService;
            this.productService = productService;

        }

        [HttpGet]
        [DealerAuthorization]
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

        [HttpGet]
        [DealerAuthorization]
        public async Task<IActionResult> Delete()
        {
            var categories = await productService.GetAllCategoriesAsync();
            var model = categories
                .Select(c => new CategoryFormViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList();

            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var category = await productService.GetCategoryByIdAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            await categoryService.RemoveCategoryAsync(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
