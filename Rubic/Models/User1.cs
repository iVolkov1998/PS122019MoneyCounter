using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Models.Pimenov
{
    public class User1
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public bool isBoy { get; set; }
        public DateTime Birthday { get; set; }
        public int PhoneNumberPrefix { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AvatarUrl { get; set; }
        public string Token { get; set; }
        public Profile Profile { get; set; }
    }
}
