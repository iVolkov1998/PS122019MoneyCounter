using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Diana
{
    public class Profile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string HatlmageUrl { get; set; }
        public User User { get; set; }
    }
}
