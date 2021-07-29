using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CincyClean.Models;

namespace CincyClean.Data
{
    public class CincyCleanContext : DbContext
    {
        public CincyCleanContext (DbContextOptions<CincyCleanContext> options)
            : base(options)
        {
        }

        public DbSet<CincyClean.Models.Request> Request { get; set; }

        public DbSet<CincyClean.Models.Cleaner> Cleaner { get; set; }
    }
}
