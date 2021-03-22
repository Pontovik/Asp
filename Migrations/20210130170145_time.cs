using Microsoft.EntityFrameworkCore.Migrations;

namespace UIB.Migrations
{
    public partial class time : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Subjects");
        }
    }
}
