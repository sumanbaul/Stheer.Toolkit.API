using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Stheer.Api.Provider.Models
{
    public class Habit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column(TypeName = "int")]
        public int HabitsId { get; set; }
        public int? UserId { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string? HabitName { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string? HabitType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? IsCompleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? IsDeleted { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Code { get; set; }
    }
}
