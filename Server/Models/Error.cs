using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class Error
    {
        public int StatusCode { get; set; }
        public String Message { get; set; }
        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
