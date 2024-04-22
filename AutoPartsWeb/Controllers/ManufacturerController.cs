namespace AutoPartsWeb.Controllers
{
    using AutoPartsWeb.Attributes;
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Manufacturer;
    using Microsoft.AspNetCore.Mvc;

    public class ManufacturerController : BaseController
    {
        private readonly IManufacturerService manufacturerService;

        public ManufacturerController(IManufacturerService manufacturerService)
        {
            this.manufacturerService = manufacturerService;
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
    }
}
