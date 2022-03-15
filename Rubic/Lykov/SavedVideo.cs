using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Lykov
{
    public class SavedVideo
    {
        public int ProfileId { get; set; }

        public int VideoId { get; set; }

        public List<Video> Videos { get; set; }

        public Profile Profile { get; set; }


    }
}
