using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Student
    {
        [Key]
        public string usernameHV { get; set; }

        public string passwordHV { get; set; }
        public string NameHS { get; set; }
        public int active { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }


    }
}
