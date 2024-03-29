﻿namespace AutoPartsWeb.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants.ValidationConstants;

    [Comment("Manufacturers table")]
    public class Manufacturer
    {
        public Manufacturer()
        {
            Products = new List<Product>();
        }

        [Key]
        [Comment("Manufacturer identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ManufacturerMaxNameLength)]
        [Comment("Manufacturer name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(ManufacturerMaxCountryLength)]
        [Comment("Manufacturer country")]
        public string Country { get; set; } = string.Empty;

        [Comment("Indicates whether the manufacturer is deleted")]
        public bool IsDeleted { get; set; }

        [Comment("List of products manufactured by the manufacturer")]
        public ICollection<Product> Products { get; set; }
    }
}
