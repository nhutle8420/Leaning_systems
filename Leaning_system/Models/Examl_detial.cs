﻿using System.ComponentModel.DataAnnotations;

namespace Leaning_system.Models
{
    public class Examl_detial
    {
        public Class Class { get; set; }
        [Key]
        public int ClassID { get; set; }
       
        public DateTime day { get; set; }
        public string Context { get; set; }
        public string Time { get; set; }
        public string status { get; set; }
        public string start_xaml { get; set; }
    }
}
