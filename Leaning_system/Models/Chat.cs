using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Chat
    {
        [Key]
        public int ChatId { get; set; }
        public Class Class { get; set; }
        public int ClassID { get; set; }
        public string Question { get; set; }
    }
}
