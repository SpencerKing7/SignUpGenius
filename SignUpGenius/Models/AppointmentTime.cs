using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public class AppointmentTime
    {
        [Key]
        [Required]
        public int TimeId { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }

        public bool Available { get; set; }
    }
}
