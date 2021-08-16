using System.Collections.Generic;

namespace Server.Models
{
    public class UpdateStoreDTO : CreateStoreDTO
    {
        IList<Product> Products { get; set; }
    }
}
