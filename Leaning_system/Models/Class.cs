using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }
        public int SubjectId { get; set; }
        public string Description { get; set; }
        public int Numberday { get; set; }
        public string Time { get; set; }
        public DateTime startday  { get; set; }
        public DateTime endday { get; set; }
        public string Link { get; set; }
        public string PassClass { get; set; }
       public string Security { get; set; }
        public int status { get; set; }
        public Teacher Teacher { get; set; }
        public string usernameGV { get; set; }
        public Subjects Subjects { get; set; }
        public Student Student { get; set; }
        public string usernameHV { get; set; }

    }
}
