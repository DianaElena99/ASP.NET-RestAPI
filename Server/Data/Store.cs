using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{

    public class Store
    {
        public int Id { get; set; }
        public String Name { get; set; }
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
