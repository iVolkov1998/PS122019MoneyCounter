using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Kedrov
{
    public class Friends
    {
        public int FirstUserId { get; set; }
        public int SecondUserId { get; set; }

        public User FirstUser { get; set; }
        public User SecondUser { get; set; }
    }
}
