using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Student
    {
        [Key]
        
        public int MSSV { get; set; }
        [Required, StringLength(50)]
        public string NameHV { get; set; }
        [Required]

        public int Phone { get; set; }
        [Required, StringLength(50)]
        [EmailAddress]
        public int active { get; set; }

        public Account account { get; set; }

        


    }
}
