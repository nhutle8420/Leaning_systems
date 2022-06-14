using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string Discription { get; set; }
        public int numberday { get; set; }
        public string Time { get; set; }
        public DateTime start_day { get; set; }
        public DateTime end_day { get; set; }
        public string Link { get; set; }
        public string PassClass { get; set; }
        public string Security { get; set; }
        public int status { get; set; }
       public Student student { get; set; }
        public Teacher teacher { get; set; }
        
        public string usernameGV { get; set; }

        public string usernameHV { get; set; }
        public Subjects subjects { get; set; }
        public int SubjectId { get; set; }
    }
}
