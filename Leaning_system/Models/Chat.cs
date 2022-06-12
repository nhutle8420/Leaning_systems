using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Chat
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public Class Class { get; set; }
        public int ClassId { get; set; }
    }
}
