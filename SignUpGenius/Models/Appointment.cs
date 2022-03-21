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
        public byte GroupSize { get; set; }

        [Required]
        public string Email { get; set; }
        
        [Phone(ErrorMessage = "Type a valid 10 digit phone number")]
        public string Phone { get; set; }

        //Foreign Keys
        public int TimeId { get; set; }
        public AppointmentTime AppointmentTime { get; set; }
    }
}
