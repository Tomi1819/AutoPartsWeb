namespace AutoPartsWeb.Controllers
{
    using AutoPartsWeb.Attributes;
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Product;
    using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (await productService.ProductExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var product = await productService.GetProductByIdAsync(id);

            if (User.Id() != product.UserId)
            {
                return Unauthorized();
            }

            var categories = await productService.GetAllCategoriesAsync();
            var manufacturers = await productService.GetAllManufacturersAsync();

            product.Categories = categories;
            product.Manufacturers = manufacturers;

            return View(product);
        }

        [HttpPost]
        [Authorize(Roles = "Dealer")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductFormViewModel model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                var categories = await productService.GetAllCategoriesAsync();
                var manufacturers = await productService.GetAllManufacturersAsync();
                model.Categories = categories;
                model.Manufacturers = manufacturers;

                return View(model);
            }

            if (!await productService.ProductExistsAsync(id))
            {
                return BadRequest();
            }

            var product = await productService.GetProductByIdAsync(id);
            if (User.Id() != product.UserId)
            {
                return Unauthorized();
            }

            await productService.EditProductAsync(model, product.Id);

            return RedirectToAction(nameof(Details), new { id = model.Id });
        }
    }
}
