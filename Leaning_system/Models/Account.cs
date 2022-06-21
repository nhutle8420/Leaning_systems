using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Account
    {
        [Key]
        [Required, StringLength(50)]
        public String UserName { get; set; }
    
        [Required, StringLength(16)]
        public string PassWord { get; set; }
        public Power power { get; set; }
    }
}
