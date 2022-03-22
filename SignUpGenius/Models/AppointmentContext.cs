
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
                    Date = "Monday",
                    Time = "8:00 AM",
                    GroupName = "Tracy Clan",
                    GroupSize = 15,
                    Email = "tracyclan@email.com",
                    Phone = "8012223333"
                },
                new Appointment
                {
                    AppointmentId = 2,
                    Date = "Monday",
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
                    Date = "Monday",
                    Time = "8:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 2,
                    Date = "Monday",
                    Time = "9:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 3,
                    Date = "Monday",
                    Time = "10:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 4,
                    Date = "Monday",
                    Time = "11:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 5,
                    Date = "Monday",
                    Time = "12:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 6,
                    Date = "Monday",
                    Time = "1:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 7,
                    Date = "Monday",
                    Time = "2:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 8,
                    Date = "Monday",
                    Time = "3:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 9,
                    Date = "Monday",
                    Time = "4:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 10,
                    Date = "Monday",
                    Time = "5:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 11,
                    Date = "Monday",
                    Time = "6:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 12,
                    Date = "Monday",
                    Time = "7:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 13,
                    Date = "Monday",
                    Time = "8:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 14,
                    Date = "Tuesday",
                    Time = "8:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 15,
                    Date = "Tuesday",
                    Time = "9:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 16,
                    Date = "Tuesday",
                    Time = "10:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 17,
                    Date = "Tuesday",
                    Time = "11:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 18,
                    Date = "Tuesday",
                    Time = "12:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 19,
                    Date = "Tuesday",
                    Time = "1:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 20,
                    Date = "Tuesday",
                    Time = "2:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 21,
                    Date = "Tuesday",
                    Time = "3:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 22,
                    Date = "Tuesday",
                    Time = "4:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 23,
                    Date = "Tuesday",
                    Time = "5:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 24,
                    Date = "Tuesday",
                    Time = "6:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 25,
                    Date = "Tuesday",
                    Time = "7:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 26,
                    Date = "Tuesday",
                    Time = "8:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 27,
                    Date = "Wednesday",
                    Time = "8:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 28,
                    Date = "Wednesday",
                    Time = "9:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 29,
                    Date = "Wednesday",
                    Time = "10:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 30,
                    Date = "Wednesday",
                    Time = "11:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 31,
                    Date = "Wednesday",
                    Time = "12:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 32,
                    Date = "Wednesday",
                    Time = "1:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 33,
                    Date = "Wednesday",
                    Time = "2:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 34,
                    Date = "Wednesday",
                    Time = "3:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 35,
                    Date = "Wednesday",
                    Time = "4:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 36,
                    Date = "Wednesday",
                    Time = "5:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 37,
                    Date = "Wednesday",
                    Time = "6:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 38,
                    Date = "Wednesday",
                    Time = "7:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 39,
                    Date = "Wednesday",
                    Time = "8:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 40,
                    Date = "Thursday",
                    Time = "8:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 41,
                    Date = "Thursday",
                    Time = "9:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 42,
                    Date = "Thursday",
                    Time = "10:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 43,
                    Date = "Thursday",
                    Time = "11:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 44,
                    Date = "Thursday",
                    Time = "12:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 45,
                    Date = "Thursday",
                    Time = "1:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 46,
                    Date = "Thursday",
                    Time = "2:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 47,
                    Date = "Thursday",
                    Time = "3:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 48,
                    Date = "Thursday",
                    Time = "4:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 49,
                    Date = "Thursday",
                    Time = "5:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 50,
                    Date = "Thursday",
                    Time = "6:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 51,
                    Date = "Thursday",
                    Time = "7:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 52,
                    Date = "Thursday",
                    Time = "8:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 53,
                    Date = "Friday",
                    Time = "8:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 54,
                    Date = "Friday",
                    Time = "9:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 55,
                    Date = "Friday",
                    Time = "10:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 56,
                    Date = "Friday",
                    Time = "11:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 57,
                    Date = "Friday",
                    Time = "12:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 58,
                    Date = "Friday",
                    Time = "1:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 59,
                    Date = "Friday",
                    Time = "2:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 60,
                    Date = "Friday",
                    Time = "3:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 61,
                    Date = "Friday",
                    Time = "4:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 62,
                    Date = "Friday",
                    Time = "5:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 63,
                    Date = "Friday",
                    Time = "6:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 64,
                    Date = "Friday",
                    Time = "7:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 65,
                    Date = "Friday",
                    Time = "8:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 66,
                    Date = "Saturday",
                    Time = "8:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 67,
                    Date = "Saturday",
                    Time = "9:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 68,
                    Date = "Saturday",
                    Time = "10:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 69,
                    Date = "Saturday",
                    Time = "11:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 70,
                    Date = "Saturday",
                    Time = "12:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 71,
                    Date = "Saturday",
                    Time = "1:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 72,
                    Date = "Saturday",
                    Time = "2:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 73,
                    Date = "Saturday",
                    Time = "3:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 74,
                    Date = "Saturday",
                    Time = "4:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 75,
                    Date = "Saturday",
                    Time = "5:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 76,
                    Date = "Saturday",
                    Time = "6:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 77,
                    Date = "Saturday",
                    Time = "7:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 78,
                    Date = "Saturday",
                    Time = "8:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 79,
                    Date = "Sunday",
                    Time = "8:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 80,
                    Date = "Sunday",
                    Time = "9:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 81,
                    Date = "Sunday",
                    Time = "10:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 82,
                    Date = "Sunday",
                    Time = "11:00 AM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 83,
                    Date = "Sunday",
                    Time = "12:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 84,
                    Date = "Sunday",
                    Time = "1:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 85,
                    Date = "Sunday",
                    Time = "2:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 86,
                    Date = "Sunday",
                    Time = "3:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 87,
                    Date = "Sunday",
                    Time = "4:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 88,
                    Date = "Sunday",
                    Time = "5:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 89,
                    Date = "Sunday",
                    Time = "6:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 90,
                    Date = "Sunday",
                    Time = "7:00 PM",
                    Available = true
                },
                new AppointmentTime
                {
                    TimeId = 91,
                    Date = "Sunday",
                    Time = "8:00 PM",
                    Available = true
                }
            );
        }
    }
}
