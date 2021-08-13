using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class CreateProductDTO
    {
        [Required]
        [StringLength(maximumLength: 150)]
        public String Name { get; set; }
        [Required]
        public Double Price { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(Store))]
        public int StoreId { get; set; }
    }
}
