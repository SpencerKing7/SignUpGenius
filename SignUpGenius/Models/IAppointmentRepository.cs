using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public interface IAppointmentRepository
    {
        IQueryable<Appointment> Appointments { get; }

        //Edit
        public void SaveAppointment(Appointment a);
        //Create
        public void CreateAppointment(Appointment a);
        //Delete
        public void DeleteAppointment(Appointment a);
    }
}
