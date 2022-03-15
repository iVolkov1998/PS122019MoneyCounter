using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Astashin
{
    public class SavedVideo
    {
        public int ProfileId { get; set; }
        public int VideoId { get; set; }
        public  Profile Profile { get; set; }
        public Video Video { get; set; }
    }
}
