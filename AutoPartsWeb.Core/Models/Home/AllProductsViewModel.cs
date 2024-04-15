namespace AutoPartsWeb.Core.Models.Home
{
    public class AllProductsViewModel
    {
        public AllProductsViewModel()
        {
            Products = new List<ProductIndexViewModel>();
        }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 6;
        public int TotalPages { get; set; }
        public IEnumerable<ProductIndexViewModel> Products { get; set; }
    }
}
