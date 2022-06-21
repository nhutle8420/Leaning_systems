using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Subjects
    {
        [Key]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; } 
        public string schedule { get; set; }
        public string Time { get; set; }

    }
}
