using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class _7311610 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutherId",
                table: "Suggests",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutherId",
                table: "Suggests");
        }
    }
}
