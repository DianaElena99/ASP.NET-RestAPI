using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class ProductDTO : CreateProductDTO
    {
        public int Id { get; set; }

        public Store Store { get; set; }
    }
}
