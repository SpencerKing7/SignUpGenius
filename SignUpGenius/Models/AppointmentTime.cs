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
        public DateTime Time { get; set; }
    }
}
