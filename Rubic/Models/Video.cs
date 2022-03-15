using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Models.Pimenov
{
    public class Video
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string ContentUrl { get; set; }
        public Profile Profile { get; set; } 
        public List<SavedVideo> SavedVideos { get; set; } = new List<SavedVideo>();
        public List<VideoComment> VideoComments { get; set; } = new List<VideoComment>();
    }
}
