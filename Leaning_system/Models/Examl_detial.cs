using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Examl_detial
    {
        [Key]
        public string Context { get; set; }
     


        public string day { get; set; }
      
        public string Time { get; set; }
        public string status { get; set; }
        public DateTime start_xaml { get; set; }
        public Class Class { get; set; }
    }
}
