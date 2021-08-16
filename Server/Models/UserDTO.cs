using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class LoginDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Required]
        public String Password { get; set; }
    }

    public class UserDTO : LoginDTO
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }
        public ICollection<String> Roles { get; set; }
    }
}
