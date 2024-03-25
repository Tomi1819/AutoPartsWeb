namespace AutoPartsWeb.Infrastructure.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static DataConstants.ValidationConstants;

    [Comment("Dealers table")]
    public class Dealer
    {
        public Dealer()
        {
            Products = new List<Product>();
            Orders = new List<Order>();
        }

        [Key]
        [Comment("Dealer identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DealerMaxNameLenght)]
        [Comment("Dealer name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(DealerCompanyNameMaxLenght)]
        [Comment("Comapany name")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [MaxLength(DealerCompanyNumberMaxLenght)]
        [Comment("Comapany number")]
        public string CompanyNumber { get; set; } = string.Empty;

        [MaxLength(DealerDescriptionMaxLenght)]
        [Comment("Dealer description")]
        public string Description { get; set; } = string.Empty;

        public bool IsDeleted { get; set; }

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Comment("List of products offered by the dealer")]
        public ICollection<Product> Products { get; set; }

        [Comment("List of orders made to the dealer")]
        public ICollection<Order> Orders { get; set; }
    }
}
