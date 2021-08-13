using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class StoreDTO : CreateStoreDTO
    {
        public int Id { get; set; }
        public IList<ProductDTO> Products { get; set; }
    }
}
