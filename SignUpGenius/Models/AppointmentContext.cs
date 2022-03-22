
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SignUpGenius.Models
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext()
        {
        }

        public AppointmentContext(DbContextOptions<AppointmentContext> options)
            : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<AppointmentTime> AppointmentTimes { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(

                new Appointment
                {
                    AppointmentId = 1,
                    Date = "3/21/2022",
                    Time = "8:00 AM",
                    GroupName = "Tracy Clan",
                    GroupSize = 15,
                    Email = "tracyclan@email.com",
                    Phone = "8012223333"
                },
                new Appointment
                {
                    AppointmentId = 2,
                    Date = "3/21/2022",
                    Time = "9:00 AM",
                    GroupName = "King Family",
                    GroupSize = 10,
                    Email = "kingfam@email.com",
                    Phone = "8014445555"
                }
            );

            mb.Entity<AppointmentTime>().HasData(

                new AppointmentTime
                {
                    TimeId = 1,
                    Date = "3/21/2022",
                    Time = "8:00 AM",
                    Available = false
                },
                new AppointmentTime
                {
                    TimeId = 2,
                    Date = "3/21/2022",
                    Time = "9:00 AM",
                    Available = false
                },
                new AppointmentTime
                {
                    TimeId = 3,
                    Date = "3/21/2022",
                    Time = "10:00 AM",
                    Available = false
                },
                new AppointmentTime
                {
                    TimeId = 4,
                    Date = "3/21/2022",
                    Time = "11:00 AM",
                    Available = false
                },
                new AppointmentTime
                {
                    TimeId = 5,
                    Date = "3/21/2022",
                    Time = "12:00 PM",
                    Available = false
                },
                new AppointmentTime
                {
                    TimeId = 6,
                    Date = "3/21/2022",
                    Time = "1:00 PM",
                    Available = false
                },
                new AppointmentTime
                {
                    TimeId = 7,
                    Date = "3/21/2022",
                    Time = "2:00 PM",
                    Available = false
                },
                new AppointmentTime
                {
                    TimeId = 8,
                    Date = "3/21/2022",
                    Time = "3:00 PM",
                    Available = false
                },
                new AppointmentTime
                {
                    TimeId = 9,
                    Date = "3/21/2022",
                    Time = "4:00 PM",
                    Available = false
                },
                new AppointmentTime
                {
                    TimeId = 10,
                    Date = "3/21/2022",
                    Time = "5:00 PM",
                    Available = false
                },
                new AppointmentTime
                {
                    TimeId = 11,
                    Date = "3/21/2022",
                    Time = "6:00 PM",
                    Available = false
                },
                new AppointmentTime
                {
                    TimeId = 12,
                    Date = "3/21/2022",
                    Time = "7:00 PM",
                    Available = false
                },
                new AppointmentTime
                {
                    TimeId = 13,
                    Date = "3/21/2022",
                    Time = "8:00 PM",
                    Available = false
                }
            );
        }
    }
}
