namespace AutoPartsWeb.Core.Models.Product
{
    public class ProductDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public double Rating { get; set; }
        public string ManufacturerName { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
    }
}
