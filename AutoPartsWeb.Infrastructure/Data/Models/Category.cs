namespace AutoPartsWeb.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants.ValidationConstants;

    [Comment("Categories table")]
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        [Key]
        [Comment("Category identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryMaxNameLength)]
        [Comment("Category name")]
        public string Name { get; set; } = string.Empty;

        [Comment("Indicates whether the category is deleted")]
        public bool IsDeleted { get; set; }

        [Comment("List of products in this category")]
        public ICollection<Product> Products { get; set; }
    }
}
