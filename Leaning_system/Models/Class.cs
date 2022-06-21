using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string NamCLass { set; get; }
        [Required]
        public string Time { get; set; }
        [Required, StringLength(50)]
        public string Discription { get; set; }
        [Required, StringLength(50)]
        public string monhoc { get; set; }
        [Required, StringLength(50)]
        public int MaGV { get; set; }
        [Required, StringLength(50)]
        public int status { get; set; }
        [Required, StringLength(50)]
        public string Link { get; set; }
        [Required, StringLength(50)]
        public string Security { get; set; }
        public int numberday { get; set; }
        public DateTime start_day { get; set; }
        public DateTime end_day { get; set; }

        public Subjects subjects { get; set; }
        public int SubjectId { get; set; }
    }
}
