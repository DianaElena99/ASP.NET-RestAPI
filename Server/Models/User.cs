using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public User(String Username_, String Password_, String Email_)
        {
            Username = Username_;
            Password = Password_;
            Email = Email_;
        }
    }
}
