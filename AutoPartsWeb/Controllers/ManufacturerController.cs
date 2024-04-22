namespace AutoPartsWeb.Controllers
{
    using AutoPartsWeb.Attributes;
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Manufacturer;
    using Microsoft.AspNetCore.Mvc;

    public class ManufacturerController : BaseController
    {
        private readonly IManufacturerService manufacturerService;
        private readonly IProductService productService;

        public ManufacturerController(IManufacturerService manufacturerService,
            IProductService productService)
        {
            this.manufacturerService = manufacturerService;
            this.productService = productService;
        }

        [HttpGet]
        [DealerAuthorization]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ManufacturerFormViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await manufacturerService.AddManufacturerAsync(model);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [DealerAuthorization]
        public async Task<IActionResult> Delete()
        {
            var manufacturers = await productService.GetAllManufacturersAsync();
            var model = manufacturers
                .Select(m => new ManufacturerFormViewModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    Country = m.Country
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

            var manufacturer = await productService.GetManufacturerAsync(id);

            if (manufacturer == null)
            {
                return NotFound();
            }

            await manufacturerService.RemoveManufacturerAsync(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
