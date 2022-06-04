using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Courses
    {
        [Key]
        public int Course { get; set; }
        public string CoursesName { get; set; }
        public DateTime startday { get; set; }
        public DateTime endday { get; set; }
        public string Time { get; set; }
        public int status { get; set; }
        public int Numberday { get; set; }
        public Class Class { get; set; }
        public int ClassID { get; set; }
        
    }
}
