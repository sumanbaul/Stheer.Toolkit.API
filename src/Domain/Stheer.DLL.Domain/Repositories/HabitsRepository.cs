using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Stheer.Api.Provider.Models;
using Stheer.DLL.Domain.DBContext;
using Stheer.DLL.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stheer.DLL.Domain.Repositories
{
    public class HabitsRepository : IHabitsRepository
    {
        private readonly ApplicationDbContext _context;
        public HabitsRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Habit> Insert(Habit habit)
        {
            await _context.habitDetails.AddAsync(habit);
            await _context.SaveChangesAsync();
            return habit;
        }

        public async Task<HabitType> InsertHabitType(HabitType habitType)
        {
            await _context.habitTypes.AddAsync(habitType);
            await _context.SaveChangesAsync();
            return habitType;
        }
    }


    //
    //#TODO
    // Configure habitType with controller
    //

}
