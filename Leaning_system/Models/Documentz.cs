using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Documentz
    {
        [Key]
        public int MaDC { get; set; }
        public string Name { get; set; }
        public string author { get; set; }
        public int Type { get; set; }
        public string file { get; set; }
        public Teacher Teacher { get; set; }
    }
}
