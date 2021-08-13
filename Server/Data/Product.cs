using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Double Price { get; set; }
        public int Quantity { get; set; }
        [ForeignKey(nameof(Store))]
        public int StoreId { get; set; }
        public Store Store { get; set; }

    }
}
