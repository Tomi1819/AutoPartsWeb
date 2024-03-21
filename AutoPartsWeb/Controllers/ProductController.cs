namespace AutoPartsWeb.Controllers
{
    using AutoPartsWeb.Core.Contracts;
    using Microsoft.AspNetCore.Mvc;

    public class ProductController : BaseController
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
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
    }
}
