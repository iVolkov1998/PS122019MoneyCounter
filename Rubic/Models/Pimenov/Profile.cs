using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Models.Pimenov
{
    public class Profile
    {
        public int Id { get; set; }
        public string HatlmageUrl { get; set; }
        public int User1Id { get; set; }
        public User1 User1 { get; set; }
        public List<SavedVideo> SavedVideos { get; set; } = new List<SavedVideo>();
        public List<Video> Videos { get; set; } = new List<Video>();
    }
}
