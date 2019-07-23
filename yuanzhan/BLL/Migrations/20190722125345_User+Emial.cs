using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class UserEmial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "emails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_emails_OwnerId",
                table: "emails",
                column: "OwnerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_emails_users_OwnerId",
                table: "emails",
                column: "OwnerId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_emails_users_OwnerId",
                table: "emails");

            migrationBuilder.DropIndex(
                name: "IX_emails_OwnerId",
                table: "emails");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "emails");
        }
    }
}
