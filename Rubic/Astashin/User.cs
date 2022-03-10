using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Astashin
{
    public class User
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Login { get; set; }
        public int PhoneNumberPrefix { get; set; }
        public long PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public bool IsBoy { get; set; }
        public string Status { get; set; }
        public DateTime? DateTime { get; set; }

    }
}
