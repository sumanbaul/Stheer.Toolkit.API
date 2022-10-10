using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stheer.Api.Provider.Models;
using Stheer.DLL.Domain.Models;

namespace Stheer.DLL.Domain.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }

        public DbSet<Habit> habitDetails { get; set; }
        public DbSet<HabitType> habitTypes { get; set; }
    }
}
