namespace AutoPartsWeb.Core.Models.Dealer
{
    using System.ComponentModel.DataAnnotations;
    using static AutoPartsWeb.Core.Constants.MessageConstants;
    using static AutoPartsWeb.Infrastructure.DataConstants.ValidationConstants;

    public class DealerFormViewModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(DealerMaxNameLength, 
            MinimumLength = DealerMinNameLength, 
            ErrorMessage = StringLenghtErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(DealerCompanyNameMaxLength, 
            MinimumLength = DealerCompanyNameMinLength,
            ErrorMessage = StringLenghtErrorMessage)]
        public string CompanyName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(DealerCompanyNumberMaxLength,
            MinimumLength = DealerCompanyNumberMinLength,
            ErrorMessage = StringLenghtErrorMessage)]
        public string CompanyNumber { get; set; } = string.Empty;

        [StringLength(DealerDescriptionMaxLength,
            MinimumLength = DealerDescriptionMinLength,
            ErrorMessage = StringLenghtErrorMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public string UserId { get; set; } = string.Empty;
    }
}
