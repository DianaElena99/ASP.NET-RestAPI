using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class Address
    {
        public int Id { get; set; }
        public String Country { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
    }
}
