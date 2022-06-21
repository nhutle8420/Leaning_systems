using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Leaning_system.Models
{
    public class Teacher
    {
        [Key]
   
        public int MaGV { get; set; }
        [Required, StringLength(50)]
        public string NameGV { get; set; }
       
        public string phone { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public int active { get; set; }

        public Account account { get; set; }
      

    }
}
