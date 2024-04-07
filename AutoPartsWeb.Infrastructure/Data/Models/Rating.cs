namespace AutoPartsWeb.Infrastructure.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static DataConstants.ValidationConstants;

    [Comment("Ratings table")]
    public class Rating
    {
        [Key]
        [Comment("Rating identifier")]
        public int Id { get; set; }

        [Required]
        [Range(MinRatingValue, MaxRatingValue)]
        [Comment("Ratings value")]
        public int Value { get; set; }

        [Required]
        [Comment("Product identifier")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
    }
}
