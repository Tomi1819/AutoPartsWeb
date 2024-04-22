namespace AutoPartsWeb.Core.Models.Cart
{
    using AutoPartsWeb.Infrastructure.Data.Models;

    public class CartViewModel
    {
        public CartViewModel()
        {
            Products = new List<Product>();
        }

        public ICollection<Product> Products { get; set; }
    }
}
