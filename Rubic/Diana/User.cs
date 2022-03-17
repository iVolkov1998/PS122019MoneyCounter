using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Diana
{
    public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public Boolean IsBoy { get; set; }
        public DateTime Birthday { get; set; }
        public int PhoneNumberPrefix { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AvatarUrl { get; set; }
        public string Token { get; set; }
    }
}
