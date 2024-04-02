namespace AutoPartsWeb.Controllers
{
    using AutoPartsWeb.Attributes;
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Dealer;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;
    using static AutoPartsWeb.Core.Constants.MessageConstants;

    public class DealerController : BaseController
    {
        private readonly IDealerService dealerService;

        public DealerController(IDealerService dealerService)
        {
            this.dealerService = dealerService;
        }

        [HttpGet]
        [NotADealer]
        public ActionResult Become()
        {
            var model = new DealerFormViewModel();

            return View(model);
        }


        [HttpPost]
        [NotADealer]
        public async Task<IActionResult> Become(DealerFormViewModel model)
        {
            if (!await dealerService.HasNecessaryRequirementsAsync(model))
            {
                ModelState.AddModelError("Error", NotEligible);
            }

            model.UserId = User.Id();

            await dealerService.CreateDealerAsync(model);

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
