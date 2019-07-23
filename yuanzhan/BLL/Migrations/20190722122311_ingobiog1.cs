using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class ingobiog1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Blog");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Blog",
                nullable: true);
        }
    }
}
