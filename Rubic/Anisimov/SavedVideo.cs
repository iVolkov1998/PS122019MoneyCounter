using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Anisimov
{
    public class SavedVideo
    {
        public int ProfileId { get; set; }
        public int VideoId { get; set; }
        public Profile profile { get; set; }
        public Video video { get; set; }
    }
}
