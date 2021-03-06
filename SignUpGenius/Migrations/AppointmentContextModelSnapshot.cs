// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SignUpGenius.Models;

namespace SignUpGenius.Migrations
{
    [DbContext(typeof(AppointmentContext))]
    partial class AppointmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("SignUpGenius.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("AppointmentId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            AppointmentId = 1,
                            Date = "Monday",
                            Email = "tracyclan@email.com",
                            GroupName = "Tracy Clan",
                            GroupSize = (byte)15,
                            Phone = "8012223333",
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentId = 2,
                            Date = "Monday",
                            Email = "kingfam@email.com",
                            GroupName = "King Family",
                            GroupSize = (byte)10,
                            Phone = "8014445555",
                            Time = "9:00 AM"
                        });
                });

            modelBuilder.Entity("SignUpGenius.Models.AppointmentTime", b =>
                {
                    b.Property<int>("TimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("TimeId");

                    b.ToTable("AppointmentTimes");

                    b.HasData(
                        new
                        {
                            TimeId = 1,
                            Available = true,
                            Date = "Monday",
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeId = 2,
                            Available = true,
                            Date = "Monday",
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeId = 3,
                            Available = true,
                            Date = "Monday",
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeId = 4,
                            Available = true,
                            Date = "Monday",
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeId = 5,
                            Available = true,
                            Date = "Monday",
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeId = 6,
                            Available = true,
                            Date = "Monday",
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeId = 7,
                            Available = true,
                            Date = "Monday",
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeId = 8,
                            Available = true,
                            Date = "Monday",
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeId = 9,
                            Available = true,
                            Date = "Monday",
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeId = 10,
                            Available = true,
                            Date = "Monday",
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeId = 11,
                            Available = true,
                            Date = "Monday",
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeId = 12,
                            Available = true,
                            Date = "Monday",
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeId = 13,
                            Available = true,
                            Date = "Monday",
                            Time = "8:00 PM"
                        },
                        new
                        {
                            TimeId = 14,
                            Available = true,
                            Date = "Tuesday",
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeId = 15,
                            Available = true,
                            Date = "Tuesday",
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeId = 16,
                            Available = true,
                            Date = "Tuesday",
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeId = 17,
                            Available = true,
                            Date = "Tuesday",
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeId = 18,
                            Available = true,
                            Date = "Tuesday",
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeId = 19,
                            Available = true,
                            Date = "Tuesday",
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeId = 20,
                            Available = true,
                            Date = "Tuesday",
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeId = 21,
                            Available = true,
                            Date = "Tuesday",
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeId = 22,
                            Available = true,
                            Date = "Tuesday",
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeId = 23,
                            Available = true,
                            Date = "Tuesday",
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeId = 24,
                            Available = true,
                            Date = "Tuesday",
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeId = 25,
                            Available = true,
                            Date = "Tuesday",
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeId = 26,
                            Available = true,
                            Date = "Tuesday",
                            Time = "8:00 PM"
                        },
                        new
                        {
                            TimeId = 27,
                            Available = true,
                            Date = "Wednesday",
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeId = 28,
                            Available = true,
                            Date = "Wednesday",
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeId = 29,
                            Available = true,
                            Date = "Wednesday",
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeId = 30,
                            Available = true,
                            Date = "Wednesday",
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeId = 31,
                            Available = true,
                            Date = "Wednesday",
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeId = 32,
                            Available = true,
                            Date = "Wednesday",
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeId = 33,
                            Available = true,
                            Date = "Wednesday",
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeId = 34,
                            Available = true,
                            Date = "Wednesday",
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeId = 35,
                            Available = true,
                            Date = "Wednesday",
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeId = 36,
                            Available = true,
                            Date = "Wednesday",
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeId = 37,
                            Available = true,
                            Date = "Wednesday",
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeId = 38,
                            Available = true,
                            Date = "Wednesday",
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeId = 39,
                            Available = true,
                            Date = "Wednesday",
                            Time = "8:00 PM"
                        },
                        new
                        {
                            TimeId = 40,
                            Available = true,
                            Date = "Thursday",
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeId = 41,
                            Available = true,
                            Date = "Thursday",
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeId = 42,
                            Available = true,
                            Date = "Thursday",
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeId = 43,
                            Available = true,
                            Date = "Thursday",
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeId = 44,
                            Available = true,
                            Date = "Thursday",
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeId = 45,
                            Available = true,
                            Date = "Thursday",
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeId = 46,
                            Available = true,
                            Date = "Thursday",
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeId = 47,
                            Available = true,
                            Date = "Thursday",
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeId = 48,
                            Available = true,
                            Date = "Thursday",
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeId = 49,
                            Available = true,
                            Date = "Thursday",
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeId = 50,
                            Available = true,
                            Date = "Thursday",
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeId = 51,
                            Available = true,
                            Date = "Thursday",
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeId = 52,
                            Available = true,
                            Date = "Thursday",
                            Time = "8:00 PM"
                        },
                        new
                        {
                            TimeId = 53,
                            Available = true,
                            Date = "Friday",
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeId = 54,
                            Available = true,
                            Date = "Friday",
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeId = 55,
                            Available = true,
                            Date = "Friday",
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeId = 56,
                            Available = true,
                            Date = "Friday",
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeId = 57,
                            Available = true,
                            Date = "Friday",
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeId = 58,
                            Available = true,
                            Date = "Friday",
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeId = 59,
                            Available = true,
                            Date = "Friday",
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeId = 60,
                            Available = true,
                            Date = "Friday",
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeId = 61,
                            Available = true,
                            Date = "Friday",
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeId = 62,
                            Available = true,
                            Date = "Friday",
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeId = 63,
                            Available = true,
                            Date = "Friday",
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeId = 64,
                            Available = true,
                            Date = "Friday",
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeId = 65,
                            Available = true,
                            Date = "Friday",
                            Time = "8:00 PM"
                        },
                        new
                        {
                            TimeId = 66,
                            Available = true,
                            Date = "Saturday",
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeId = 67,
                            Available = true,
                            Date = "Saturday",
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeId = 68,
                            Available = true,
                            Date = "Saturday",
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeId = 69,
                            Available = true,
                            Date = "Saturday",
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeId = 70,
                            Available = true,
                            Date = "Saturday",
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeId = 71,
                            Available = true,
                            Date = "Saturday",
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeId = 72,
                            Available = true,
                            Date = "Saturday",
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeId = 73,
                            Available = true,
                            Date = "Saturday",
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeId = 74,
                            Available = true,
                            Date = "Saturday",
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeId = 75,
                            Available = true,
                            Date = "Saturday",
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeId = 76,
                            Available = true,
                            Date = "Saturday",
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeId = 77,
                            Available = true,
                            Date = "Saturday",
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeId = 78,
                            Available = true,
                            Date = "Saturday",
                            Time = "8:00 PM"
                        },
                        new
                        {
                            TimeId = 79,
                            Available = true,
                            Date = "Sunday",
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeId = 80,
                            Available = true,
                            Date = "Sunday",
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeId = 81,
                            Available = true,
                            Date = "Sunday",
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeId = 82,
                            Available = true,
                            Date = "Sunday",
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeId = 83,
                            Available = true,
                            Date = "Sunday",
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeId = 84,
                            Available = true,
                            Date = "Sunday",
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeId = 85,
                            Available = true,
                            Date = "Sunday",
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeId = 86,
                            Available = true,
                            Date = "Sunday",
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeId = 87,
                            Available = true,
                            Date = "Sunday",
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeId = 88,
                            Available = true,
                            Date = "Sunday",
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeId = 89,
                            Available = true,
                            Date = "Sunday",
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeId = 90,
                            Available = true,
                            Date = "Sunday",
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeId = 91,
                            Available = true,
                            Date = "Sunday",
                            Time = "8:00 PM"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
