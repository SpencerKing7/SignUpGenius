using Microsoft.EntityFrameworkCore.Migrations;

namespace SignUpGenius.Migrations
{
    public partial class SeededMoreTimes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 1,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 2,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 3,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 4,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 5,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 6,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 7,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 8,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 9,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 10,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 11,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 12,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 13,
                columns: new[] { "Available", "Date" },
                values: new object[] { true, "Monday" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 70, true, "Saturday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 74, true, "Saturday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 73, true, "Saturday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 72, true, "Saturday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 71, true, "Saturday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 69, true, "Saturday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 14, true, "Tuesday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 67, true, "Saturday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 66, true, "Saturday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 65, true, "Friday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 64, true, "Friday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 63, true, "Friday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 75, true, "Saturday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 68, true, "Saturday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 76, true, "Saturday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 83, true, "Sunday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 78, true, "Saturday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 79, true, "Sunday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 80, true, "Sunday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 81, true, "Sunday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 82, true, "Sunday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 62, true, "Friday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 84, true, "Sunday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 85, true, "Sunday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 86, true, "Sunday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 87, true, "Sunday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 88, true, "Sunday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 89, true, "Sunday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 90, true, "Sunday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 91, true, "Sunday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 77, true, "Saturday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 61, true, "Friday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 60, true, "Friday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 36, true, "Wednesday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 35, true, "Wednesday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 34, true, "Wednesday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 33, true, "Wednesday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 32, true, "Wednesday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 31, true, "Wednesday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 30, true, "Wednesday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 29, true, "Wednesday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 28, true, "Wednesday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 27, true, "Wednesday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 26, true, "Tuesday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 25, true, "Tuesday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 24, true, "Tuesday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 23, true, "Tuesday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 22, true, "Tuesday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 21, true, "Tuesday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 20, true, "Tuesday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 19, true, "Tuesday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 18, true, "Tuesday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 17, true, "Tuesday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 59, true, "Friday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 16, true, "Tuesday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 37, true, "Wednesday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 39, true, "Wednesday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 58, true, "Friday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 57, true, "Friday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 56, true, "Friday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 55, true, "Friday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 54, true, "Friday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 53, true, "Friday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 52, true, "Thursday", "8:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 51, true, "Thursday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 50, true, "Thursday", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 49, true, "Thursday", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 48, true, "Thursday", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 47, true, "Thursday", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 46, true, "Thursday", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 45, true, "Thursday", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 44, true, "Thursday", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 43, true, "Thursday", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 42, true, "Thursday", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 41, true, "Thursday", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 40, true, "Thursday", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 38, true, "Wednesday", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 15, true, "Tuesday", "9:00 AM" });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                column: "Date",
                value: "Monday");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                column: "Date",
                value: "Monday");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 91);

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 1,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 2,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 3,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 4,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 5,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 6,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 7,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 8,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 9,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 10,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 11,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 12,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 13,
                columns: new[] { "Available", "Date" },
                values: new object[] { false, "3/21/2022" });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                column: "Date",
                value: "3/21/2022");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                column: "Date",
                value: "3/21/2022");
        }
    }
}
