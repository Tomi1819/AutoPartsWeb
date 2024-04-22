namespace AutoPartsWeb.Core.Models.Manufacturer
{
    using System.ComponentModel.DataAnnotations;
    using static AutoPartsWeb.Core.Constants.MessageConstants;
    using static AutoPartsWeb.Infrastructure.DataConstants.ValidationConstants;

    public class ManufacturerFormViewModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(ManufacturerMaxNameLength,
            MinimumLength = ManufacturerMinNameLength,
            ErrorMessage = StringLenghtErrorMessage)]
        [Display(Name = "Manufacturer Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(ManufacturerMaxCountryLength,
            MinimumLength = ManufacturerMinCountryLength,
            ErrorMessage = StringLenghtErrorMessage)]
        [Display(Name = "Manufacturer Country")]
        public string Country { get; set; } = string.Empty;
    }
}
