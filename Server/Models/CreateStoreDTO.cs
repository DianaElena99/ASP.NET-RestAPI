using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class CreateStoreDTO
    {
        [Required]
        [StringLength(maximumLength: 150)]
        public String Name { get; set; }
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
