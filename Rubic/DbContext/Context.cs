using Microsoft.EntityFrameworkCore;
using Rubic.Models.Pimenov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.DbContext
{
    public class Context : Microsoft.EntityFrameworkCore.DbContext, IContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<User1> User1s { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<SavedVideo> SavedVideos { get; set; }
        public DbSet<VideoComment> VideoComments { get; set; }
    }
}
