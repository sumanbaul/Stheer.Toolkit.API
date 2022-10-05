using Microsoft.AspNetCore.Mvc;
using Stheer.Api.Provider.Models;

namespace Stheer.Api.Provider.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [Route(template:"[controller]")]
    public class HabitsController : Controller
    {
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
        public IActionResult InsertHabit(Habit habit)
        {
            return Ok(HabitsStatic.InsertHabits(habit));
        }

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

        public static Habit InsertHabits(Habit habits)
        {
            AllHabits.Add(habits);
            return habits;
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
