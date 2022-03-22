using Microsoft.EntityFrameworkCore.Migrations;

namespace SignUpGenius.Migrations
{
    public partial class SeededTimes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 3, false, "3/21/2022", "10:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 4, false, "3/21/2022", "11:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 5, false, "3/21/2022", "12:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 6, false, "3/21/2022", "1:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 7, false, "3/21/2022", "2:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 8, false, "3/21/2022", "3:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 9, false, "3/21/2022", "4:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 10, false, "3/21/2022", "5:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 11, false, "3/21/2022", "6:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 12, false, "3/21/2022", "7:00 PM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 13, false, "3/21/2022", "8:00 PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AppointmentTimes",
                keyColumn: "TimeId",
                keyValue: 13);
        }
    }
}
