using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models.ViewModels
{
    public class ToursViewModel
    {
        public IQueryable<Appointment> Appointments { get; set; }

        public TourInfo TourInfo { get; set; }
    }
}
