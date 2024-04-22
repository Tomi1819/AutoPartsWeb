namespace AutoPartsWeb.Controllers
{
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Cart;
    using Microsoft.AspNetCore.Mvc;

    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
    }
}
