using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Anisimov
{
    public class Video
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int ContentUrl { get; set; }
        public Profile profile { get; set; }
        public List<VideoComment> Videocomments { get; set; }
        public List<SavedVideo> SavedVideos { get; set; }
    }
}
