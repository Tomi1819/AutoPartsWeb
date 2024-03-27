namespace AutoPartsWeb.Core.Models.Dealer
{
    using System.ComponentModel.DataAnnotations;
    using static AutoPartsWeb.Infrastructure.DataConstants.ValidationConstants;

    public class DealerFormViewModel
    {
        [Required(ErrorMessage = DealerRequiredErrorMessage)]
        [StringLength(DealerMaxNameLength, 
            MinimumLength = DealerMinNameLength, 
            ErrorMessage = DealerStringLenghtErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = DealerRequiredErrorMessage)]
        [StringLength(DealerCompanyNameMaxLength, 
            MinimumLength = DealerCompanyNameMinLength,
            ErrorMessage = DealerStringLenghtErrorMessage)]
        public string CompanyName { get; set; } = string.Empty;

        [Required(ErrorMessage = DealerRequiredErrorMessage)]
        [StringLength(DealerCompanyNumberMaxLength,
            MinimumLength = DealerCompanyNumberMinLength,
            ErrorMessage = DealerStringLenghtErrorMessage)]
        public string CompanyNumber { get; set; } = string.Empty;

        [StringLength(DealerDescriptionMaxLength,
            MinimumLength = DealerDescriptionMinLength,
            ErrorMessage = DealerStringLenghtErrorMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = DealerRequiredErrorMessage)]
        public string UserId { get; set; } = string.Empty;
    }
}
