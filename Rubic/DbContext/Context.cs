using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.DbContext
{
    public class Context : Microsoft.EntityFrameworkCore.DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}
