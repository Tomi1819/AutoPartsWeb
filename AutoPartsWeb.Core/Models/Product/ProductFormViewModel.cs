namespace AutoPartsWeb.Core.Models.Product
{
    using System.ComponentModel.DataAnnotations;
    using static AutoPartsWeb.Core.Constants.MessageConstants;
    using static AutoPartsWeb.Infrastructure.DataConstants.ValidationConstants;

    public class ProductFormViewModel
    {
        public ProductFormViewModel()
        {
            Categories = new List<AllCategoriesViewModel>();
            Manufacturers = new List<AllManufacturersViewModel>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(ProductMaxNameLength, 
            MinimumLength = ProductMinNameLength,
            ErrorMessage = StringLenghtErrorMessage)]
        public string Title { get; set; } = string.Empty;

        [StringLength(ProductDescriptionMaxLength,
            MinimumLength = ProductDescriptionMinLength,
            ErrorMessage = StringLenghtErrorMessage)]
        public string Description { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(typeof(decimal),
            ProductMinPrice,
            ProductMaxPrice,
            ConvertValueInInvariantCulture =true,
            ErrorMessage = "The price must be a positive number")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(MaxRatingValue, 
            MinimumLength = MinRatingValue,
            ErrorMessage = StringLenghtErrorMessage)]
        public int Rating { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(MaxProductQuantity,
            MinimumLength = MinProductQuantity,
            ErrorMessage = StringLenghtErrorMessage)]
        public int Quantity { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public IReadOnlyCollection<AllCategoriesViewModel> Categories { get; set; }

        [Display(Name = "Manufacturer")]
        public int ManufacturerId { get; set; }
        public IReadOnlyCollection<AllManufacturersViewModel> Manufacturers { get; set; }
    }
}
