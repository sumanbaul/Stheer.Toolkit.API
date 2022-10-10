using Stheer.Api.Provider.Models;
using Stheer.DLL.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stheer.DLL.Domain.Repositories
{
    public interface IHabitsRepository
    {
        Task<Habit> Insert(Habit habit);
        Task<HabitType> InsertHabitType(HabitType habitType);
    }
}
