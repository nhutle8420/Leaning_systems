using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Courses
    {
        [Key]
        public int Course { get; set; }
        public string CourseName { get; set; }
        public DateTime start_day { get; set; }
        public DateTime end_day { get; set; }
        public string Time { get; set; }
        public int Status { get; set; }
        public int numberday { get; set; }
        public Class Class { get; set; }
        public int ClassId { get; set; }

    }
}
