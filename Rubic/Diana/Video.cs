using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Diana
{
    public class Video
    {
        public int Id { get; set; }
        public int Profileld { get; set; }
        public string ContentUrl { get; set; }
        public Profile Profile { get; set; }
    }
}
