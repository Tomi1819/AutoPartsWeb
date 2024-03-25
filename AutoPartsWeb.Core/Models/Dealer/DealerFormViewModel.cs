namespace AutoPartsWeb.Core.Models.Dealer
{
    using System.ComponentModel.DataAnnotations;
    using static AutoPartsWeb.Infrastructure.DataConstants.ValidationConstants;

    public class DealerFormViewModel
    {
        [Required(ErrorMessage = DealerRequiredErrorMessage)]
        [StringLength(DealerMaxNameLenght, 
            MinimumLength = DealerMinNameLenght, 
            ErrorMessage = DealerStringLenghtErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = DealerRequiredErrorMessage)]
        [StringLength(DealerCompanyNameMaxLenght, 
            MinimumLength = DealerCompanyNameMinLenght,
            ErrorMessage = DealerStringLenghtErrorMessage)]
        public string CompanyName { get; set; } = string.Empty;

        [Required(ErrorMessage = DealerRequiredErrorMessage)]
        [StringLength(DealerCompanyNumberMaxLenght,
            MinimumLength = DealerCompanyNumberMinLenght,
            ErrorMessage = DealerStringLenghtErrorMessage)]
        public string CompanyNumber { get; set; } = string.Empty;

        [StringLength(DealerDescriptionMaxLenght,
            MinimumLength = DealerDescriptionMinLenght,
            ErrorMessage = DealerStringLenghtErrorMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = DealerRequiredErrorMessage)]
        public string UserId { get; set; } = string.Empty;
    }
}
