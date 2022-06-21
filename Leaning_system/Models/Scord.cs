using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Scord
    {
        [Key]
        public int STT { get; set; }
        public int MaGV { get; set; }
        public int assiduity_point { get; set; }
        public int Mouth_point { get; set; }
        public float factor2 { get; set; }
        public float factor3 { get; set; }
        public float avegare { get; set; }
        public float scord_TB { get; set; }
        public string result { get; set; }
        public DateTime Upload_day { get; set; }
        public Subjects subjects { get; set; }
    }
}

