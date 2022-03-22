using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models.ViewModels
{
    public class TimeViewModel
    {
        public IQueryable<AppointmentTime> AppointmentTimes { get; set; }
    }
}
