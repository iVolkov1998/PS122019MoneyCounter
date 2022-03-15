using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.DbContext
{
    public interface IContext : IDisposable, IAsyncDisposable
    {
        DbSet<Profile> Profiles { get; set; }
        DbSet<SavedVideo> SavedVideos { get; set; }
    }
}
