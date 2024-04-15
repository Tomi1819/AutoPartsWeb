using AutoPartsWeb.Core.Contracts;
using AutoPartsWeb.Core.Models.Home;
using AutoPartsWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Drawing.Printing;

namespace AutoPartsWeb.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> logger;
        private readonly IProductService productService;
        public HomeController(
            ILogger<HomeController> logger,
            IProductService productService)
        {
            this.logger = logger;
            this.productService = productService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllProductsViewModel model)
        {
            var products = await productService.GetAllProductsAsync(model.PageNumber, model.PageSize);
            return View(products);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Search(string keywords)
        {
            var model = await productService.SearchProductsAsync(keywords);

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
