using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class email : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_emails_users_OwnerId",
                table: "emails");

            migrationBuilder.DropIndex(
                name: "IX_emails_OwnerId",
                table: "emails");

            migrationBuilder.AddColumn<int>(
                name: "EmailId",
                table: "users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_EmailId",
                table: "users",
                column: "EmailId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_emails_EmailId",
                table: "users",
                column: "EmailId",
                principalTable: "emails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_emails_EmailId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_EmailId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "users");

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
    }
}
