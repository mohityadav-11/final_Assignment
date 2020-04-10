using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalAssignment_aspNetCore.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "empName",
                table: "empLeaveMaps",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "leaveNAme",
                table: "empLeaveMaps",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "empLeaveMaps",
                keyColumn: "mapId",
                keyValue: 1,
                columns: new[] { "empName", "leaveNAme" },
                values: new object[] { "Mohit Yadav", "Casual Leave" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "empName",
                table: "empLeaveMaps");

            migrationBuilder.DropColumn(
                name: "leaveNAme",
                table: "empLeaveMaps");
        }
    }
}
