using Microsoft.EntityFrameworkCore;
using Rubic.Anisimov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Rubic.DbContext
{
    public interface IContext : IDisposable, IAsyncDisposable
    {
        DbSet<User> Users { get; set; }
        DbSet<Profile> Profiles { get; set; }
        DbSet<SavedVideo> SavedVideos { get; set; }
        DbSet<Video> Videos { get; set; }
        DbSet<VideoComment> VideoComments { get; set; }
        Task<int> SaveChangesAsync(CancellationToken CancellationToken = default);
    }
}
