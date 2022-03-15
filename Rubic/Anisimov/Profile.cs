﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Anisimov
{
    public class Profile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string HatImageUrl { get; set; }
        public User User { get; set; }
        public List<Video> Videos { get; set; }
        public List<SavedVideo> SavedVideos { get; set; }
    }
}
