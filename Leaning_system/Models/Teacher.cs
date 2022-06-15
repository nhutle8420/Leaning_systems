﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Leaning_system.Models
{
    public class Teacher
    {
        [Key]
        public string usernameGV { get; set; }

        public string passwordGV { get; set; }
        public string NameGV { get; set; }
        public int active { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }

        public Power Power { get; set; }
        public int Id { get; set; }

    }
}
