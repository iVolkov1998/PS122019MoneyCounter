using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Anisimov
{
    public class Friends
    {
        public int LeftId { get; set; }
        public int RightId { get; set; }
        public User Left { get; set; }
        public User Right { get; set; }
    }
}
