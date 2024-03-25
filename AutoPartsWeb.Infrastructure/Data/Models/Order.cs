namespace AutoPartsWeb.Infrastructure.Data.Models
{
    using Microsoft.AspNetCore.Identity;
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

        [Comment("Status of order")]
        public string Status { get; set; } = string.Empty;

        [Comment("Dealer identifier")]
        public int DealerId { get; set; }

        [ForeignKey(nameof(DealerId))]
        public Dealer Dealer { get; set; }

        [Comment("List of order details for the order")]
        public ICollection<OrderDetail> OrdersDetails { get; set; }
    }
}
