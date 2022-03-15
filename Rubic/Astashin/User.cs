using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Astashin
{
    public class User
    {
        public int Id { get; set; }
        public int PhoneNumberPrefix { get; set; }
        public long PhoneNumber { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public bool IsBoy { get; set; }
        public DateTime Brithday { get; set; }
        public string AvatarUrl { get; set; }
        public string Token { get; set; }
        public  Profile Profile { get; set; }
    }
}
