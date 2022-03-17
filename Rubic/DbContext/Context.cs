using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rubic.Astashin;

namespace Rubic.DbContext
{
    public class Context : Microsoft.EntityFrameworkCore.DbContext, IContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoComment> VideoComments { get; set; }
        public DbSet<SavedVideo> SavedVideos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SavedVideo>(builder =>
            {
                builder.HasKey(e => new
                {
                    e.ProfileId,
                    e.VideoId
                });

                builder.HasIndex(e => e.ProfileId);
                builder.HasIndex(e => e.VideoId);

                builder.HasOne<Video>(e => e.Video)
                     .WithMany(e => e.SavedVideos)
                     .HasForeignKey(e => e.VideoId)
                     .OnDelete(DeleteBehavior.NoAction)
                     .IsRequired();

                builder.HasOne<Profile>(e => e.Profile)
                     .WithMany(e => e.SavedVideos)
                     .HasForeignKey(e => e.ProfileId)
                     .OnDelete(DeleteBehavior.NoAction)
                     .IsRequired();
            });
        }
    }
}
