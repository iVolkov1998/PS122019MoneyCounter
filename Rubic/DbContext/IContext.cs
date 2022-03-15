using Microsoft.EntityFrameworkCore;
using Rubic.Models.Pimenov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Rubic.DbContext
{
    interface IContext : IDisposable, IAsyncDisposable
    {
        DbSet<Profile> Profiles { get; set; }
        DbSet<User1> User1s { get; set; }
        DbSet<Video> Videos { get; set; }
        DbSet<SavedVideo> SavedVideos { get; set; }
        DbSet<VideoComment> VideoComments { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

