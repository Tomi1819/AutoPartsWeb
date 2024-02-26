namespace AutoPartsWeb.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Comment("Orders table")]
    public class Order
    {
        public Order()
        {
            OrdersDetails = new List<OrderDetail>();
        }

        [Key]
        [Comment("Order identifier")]
        public int Id { get; set; }

        [Comment("Order date")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Comment("Customer identifier")]
        public string CustomerId { get; set; } = string.Empty;

        [Required]
        [Comment("Total order amount")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [Comment("List of order details for the order")]
        public ICollection<OrderDetail> OrdersDetails { get; set; }
    }
}
