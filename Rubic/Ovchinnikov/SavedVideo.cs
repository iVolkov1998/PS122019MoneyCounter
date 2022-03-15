using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Ovchinnikov
{
    public class SavedVideo
    {
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public int VideoId { get; set; }
        public Video Video { get; set; }
    }
}
