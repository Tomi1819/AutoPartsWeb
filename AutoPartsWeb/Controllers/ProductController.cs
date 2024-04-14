namespace AutoPartsWeb.Controllers
{
    using AutoPartsWeb.Attributes;
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Product;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.DotNet.Scaffolding.Shared.Project;
    using System.Security.Claims;

    public class ProductController : BaseController
    {
        private readonly IProductService productService;
        private readonly IDealerService dealerService;

        public ProductController(IProductService productService,
            IDealerService dealerService)
        {
            this.productService = productService;
            this.dealerService = dealerService;
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var productDetails = await productService.GetProductByIdAsync(id);

            if (productDetails == null)
            {
                return NotFound();
            }

            return View(productDetails);
        }

        [HttpGet]
        [DealerAuthorization]
        public async Task<IActionResult> Add()
        {
            var model = new ProductFormViewModel()
            {
                Manufacturers = await productService.GetAllManufacturersAsync(),
                Categories = await productService.GetAllCategoriesAsync()
            };

            return View(model);
        }

        [HttpPost]
        [DealerAuthorization]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Add(ProductFormViewModel model)
        {
            if (await productService.CategoryExistsAsync(model.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category doesn't exists!");
            }

            if (await productService.ManufacturerExistAsync(model.ManufacturerId) == false)
            {
                ModelState.AddModelError(nameof(model.ManufacturerId), "Manufacturer doesn't exists!");
            }

            if (ModelState.IsValid == false)
            {
                model.Categories = await productService.GetAllCategoriesAsync();
                model.Manufacturers = await productService.GetAllManufacturersAsync();

                return View(model);
            }

            var dealerId = await dealerService.GetDealerIdAsync(User.Id());

            var newProductId = await productService.CreateAsync(model, dealerId ?? 0);

            return RedirectToAction(nameof(Details), new { id = newProductId });
        }
    }
}
