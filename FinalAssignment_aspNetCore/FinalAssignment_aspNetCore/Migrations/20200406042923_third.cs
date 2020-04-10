using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalAssignment_aspNetCore.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "leaveNAme",
                table: "empLeaveMaps",
                newName: "leaveName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "leaveName",
                table: "empLeaveMaps",
                newName: "leaveNAme");
        }
    }
}
