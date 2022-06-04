using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Power
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
