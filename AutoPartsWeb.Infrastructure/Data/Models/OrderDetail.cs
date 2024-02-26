namespace AutoPartsWeb.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Comment("OrdersDetails table")]
    public class OrderDetail
    {
        [Comment("Order detail identifier")]
        public int OrderDetailId { get; set; }

        [Required]
        [Comment("Order identifier")]
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;

        [Required]
        [Comment("Product identifier")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Required]
        [Comment("Quantity of the product in the order")]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Comment("Unit price of the product in the order")]
        public decimal UnitPrice { get; set; }
    }
}