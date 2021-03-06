using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public class EFTimeRepository : ITimeRepository
    {
        private AppointmentContext context { get; set; }

        public EFTimeRepository (AppointmentContext temp)
        {
            context = temp;
        }

        public IQueryable<AppointmentTime> AppointmentTimes => context.AppointmentTimes;

        public void SaveTime(AppointmentTime at)
        {
            context.Update(at);
            context.SaveChanges();
        }
    }
}
