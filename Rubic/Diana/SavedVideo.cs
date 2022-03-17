using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Diana
{
    public class SavedVideo
    {
        public int Profileld { get; set; }
        public int VideoId { get; set; }
        public Profile Profile { get; set; }
        public Video Video { get; set; }
    }
}
