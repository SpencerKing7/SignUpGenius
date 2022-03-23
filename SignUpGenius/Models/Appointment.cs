using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int AppointmentId { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        [Range(0, 15)]
        public byte GroupSize { get; set; }

        [Required]
        public string Email { get; set; }
        
        [Phone(ErrorMessage = "Type a valid 10 digit phone number")]
        public string Phone { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }
    }
}
