using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models.ViewModels
{
    public class AppointmentViewModel
    {
        public IQueryable<Appointment> Appointments { get; set; }

        public AppointmentInfo TourInfo { get; set; }
    }
}
