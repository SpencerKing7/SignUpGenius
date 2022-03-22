using Microsoft.EntityFrameworkCore.Migrations;

namespace SignUpGenius.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<byte>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentTimes",
                columns: table => new
                {
                    TimeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentTimes", x => x.TimeId);
                });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 1, false, "3/21/2022", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "AppointmentTimes",
                columns: new[] { "TimeId", "Available", "Date", "Time" },
                values: new object[] { 2, false, "3/21/2022", "9:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Date", "Email", "GroupName", "GroupSize", "Phone", "Time" },
                values: new object[] { 1, "3/21/2022", "tracyclan@email.com", "Tracy Clan", (byte)15, "8012223333", "8:00 AM" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Date", "Email", "GroupName", "GroupSize", "Phone", "Time" },
                values: new object[] { 2, "3/21/2022", "kingfam@email.com", "King Family", (byte)10, "8014445555", "9:00 AM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AppointmentTimes");
        }
    }
}
