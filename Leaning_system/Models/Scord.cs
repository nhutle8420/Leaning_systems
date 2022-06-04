using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Scord
    {
        
        public int SubjectId { get; set; }
      
        public Class Class { get; set; }
      
        public int ClassID { get; set; }
        [Key]
        public string usernameHV { get; set; }
        public string usernameGV { get; set; }
        public int assiduity_point { get; set; }
        public int Mouth_point { get; set; }
        public int factor2 { get; set; }
        public int factor3 { get; set; }
        public int avegare { get; set; }
        public int scord_TB { get; set; }
        public string result { get; set; }
        public DateTime Upload_day { get; set; }
    }
}
