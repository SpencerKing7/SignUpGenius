using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public interface ITimeRepository
    {
        public IQueryable<AppointmentTime> AppointmentTimes { get; }
    }
}
