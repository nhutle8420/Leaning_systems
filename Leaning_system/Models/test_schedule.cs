using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class test_schedule
    {
        public Subjects Subjects { get; set; }
        
        public DateTime Day_test { get; set; }
        public string time { get;set; }
        public string form { get; set; }
        public string contest { get; set; }
        [Key]
        public string Topic { get; set; }
        public DateTime start_test { get; set; }
        public DateTime end_test { get; set; }
        public string description { get; set; }
        public string file { get; set; }
    }
}
