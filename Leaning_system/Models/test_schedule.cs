using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class test_schedule
    {
        [Key]
        public int ID_test { get; set; }
       
        [Required, StringLength(100)]
        
        public string Topic { get; set; }
        public DateTime Day_test { get; set; }
        public string time { get; set; }
        public string form { get; set; }
        public string contest { get; set; }
        [Required, StringLength(50)]
        public string NamGV { get; set; }
       
        [Required, StringLength(50)]
        public string status { get; set; }
        [StringLength(50)]
       
        public DateTime start_test { get; set; }
        public DateTime end_test { get; set; }
        public string description { get; set; }
        public string file { get; set; }
        public Subjects Subjects { get; set; }

    }
}
