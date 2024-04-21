namespace AutoPartsWeb.Core.Models.Category
{
    using System.ComponentModel.DataAnnotations;
    using static AutoPartsWeb.Core.Constants.MessageConstants;
    using static AutoPartsWeb.Infrastructure.DataConstants.ValidationConstants;

    public class CategoryFormViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(CategoryMaxNameLength,
            MinimumLength = CategoryMinNameLength,
            ErrorMessage = StringLenghtErrorMessage)]
        [Display(Name = "Category Name")]
        public string Name { get; set; } = string.Empty;
    }
}
