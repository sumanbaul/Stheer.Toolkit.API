using Microsoft.AspNetCore.Mvc;
using Stheer.Api.Provider.Models;
using Stheer.DLL.Domain.Models;
using Stheer.DLL.Domain.Repositories;

namespace Stheer.Api.Provider.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [Route(template:"[controller]")]
    public class HabitsController : Controller
    {
        private readonly IHabitsRepository _habitsRepository;

        public HabitsController(IHabitsRepository habitsRepository)
        {
            _habitsRepository = habitsRepository;
        }

        [HttpGet]
        public IActionResult GetAllHabits()
        {
            return Ok(HabitsStatic.GetAllHabits());
        }

        [HttpGet(template:"{code}")]
        public  IActionResult GetAHabit(string code)
        {
            return Ok(HabitsStatic.GetAHabit(code));
        }

        [HttpPost]
        public async Task<IActionResult> InsertHabit(Habit habit)
        {
            return Ok(await _habitsRepository.Insert(habit));
        }

        //[HttpPost]
        //public async Task<IActionResult> InsertHabitType(HabitType habitType)
        //{
        //    return Ok(await _habitsRepository.InsertHabitType(habitType));
        //}

        [HttpPut(template:"{code}")]
        public IActionResult UpdateHabit(string code, Habit habit)
        {
            return Ok(HabitsStatic.UpdateHabit(code, habit));
        }

        [HttpDelete(template: "{code}")]
        public IActionResult DeleteHabit(string code)
        {
            return Ok(HabitsStatic.DeleteHabit(code));
        }
    }


    public static class HabitsStatic
    {
        public static List<Habit> AllHabits { get; set; } = new List<Habit>();
        public static List<HabitType> AllHabitsType { get; set; } = new List<HabitType>();

        public static Habit InsertHabits(Habit habits)
        {
            AllHabits.Add(habits);
            return habits;
        }

        public static HabitType InsertHabitType(HabitType habitType)
        {
            AllHabitsType.Add(habitType);
            return habitType;
        }

        public static List<Habit> GetAllHabits()
        {
            return AllHabits;
        }

        public static Habit GetAHabit(string code)
        {
            var requestedHabit =  AllHabits.FirstOrDefault(x=>x.Code == code);
            if(requestedHabit == null)
            {
                return null;
            }
            return requestedHabit;
        }

        public static Habit UpdateHabit(string code, Habit habit)
        {
            Habit result = new Habit();
            foreach(var item in AllHabits)
            {
                if(code == item.Code)
                {
                    item.HabitName = habit.HabitName;
                    result = item;
                }
            }

            return result;
        }

        public static Habit DeleteHabit(string code)
        {
            var habit = AllHabits.FirstOrDefault(x => x.Code == code);
            AllHabits = AllHabits.Where(x => x.Code != habit?.Code).ToList();
            return habit;
        }
    }
}
