using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalAssignment_aspNetCore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "empLeaveMaps",
                columns: table => new
                {
                    mapId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empId = table.Column<int>(nullable: false),
                    leaveId = table.Column<int>(nullable: false),
                    leaveStartDate = table.Column<string>(nullable: true),
                    leaveEndDate = table.Column<string>(nullable: true),
                    leaveStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empLeaveMaps", x => x.mapId);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    emplyeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeName = table.Column<string>(nullable: true),
                    employeeDob = table.Column<string>(nullable: true),
                    employeeDoj = table.Column<string>(nullable: true),
                    employeeEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.emplyeeId);
                });

            migrationBuilder.CreateTable(
                name: "leaves",
                columns: table => new
                {
                    leaveId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    leaveName = table.Column<string>(nullable: true),
                    leaveMaxNoOfDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leaves", x => x.leaveId);
                });

            migrationBuilder.InsertData(
                table: "empLeaveMaps",
                columns: new[] { "mapId", "empId", "leaveEndDate", "leaveId", "leaveStartDate", "leaveStatus" },
                values: new object[] { 1, 1, "14/02/2016", 1, "10/02/2016", "Taken" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "emplyeeId", "employeeDob", "employeeDoj", "employeeEmail", "employeeName" },
                values: new object[] { 1, "13/11/1991", "10/05/2007", "Mohityadav6532@gmail.com", "Mohit Yadav" });

            migrationBuilder.InsertData(
                table: "leaves",
                columns: new[] { "leaveId", "leaveMaxNoOfDays", "leaveName" },
                values: new object[] { 1, 20, "Casual Leave" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "empLeaveMaps");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "leaves");
        }
    }
}
