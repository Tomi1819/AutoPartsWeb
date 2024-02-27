namespace AutoPartsWeb.Infrastructure.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static DataConstants.ValidationConstants;

    [Comment("Products table")]
    public class Product
    {
        public Product()
        {
            OrdersDetails = new List<OrderDetail>();
            Ratings = new List<Rating>();
        }

        [Key]
        [Comment("Product identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ProductMaxNameLenght)]
        [Comment("Product name")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(ProductDescriptionMaxLenght)]
        [Comment("Product description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Product price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Comment("Quantity in stock")]
        public int StockQuantity { get; set; }

        [Comment("Product image")]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("Indicates whether the product is deleted")]
        public bool IsDeleted { get; set; }

        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Comment("Manufacturer identifier")]
        public int ManufacturerId { get; set; }

        [ForeignKey(nameof(ManufacturerId))]
        public Manufacturer Manufacturer { get; set; } = null!;

        [Comment("Category identifier")]
        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;

        [Comment("List of order details for the product")]
        public ICollection<OrderDetail> OrdersDetails { get; set; }

        [Comment("List of ratings for the product")]
        public ICollection<Rating> Ratings { get; set; }
    }
}