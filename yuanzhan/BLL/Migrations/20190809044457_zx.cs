using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class zx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    PublishSuggestDateTime = table.Column<DateTime>(nullable: false),
                    DiscriminatorType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    PublishSuggestDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    ValidationCode = table.Column<string>(nullable: true),
                    EmailHasValidated = table.Column<DateTime>(nullable: true),
                    OwnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Keyword",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    PublishSuggestDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyword", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Context = table.Column<string>(nullable: true),
                    PublishMessageTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suggests",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    PublishSuggestDateTime = table.Column<DateTime>(nullable: false),
                    AutherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPost",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PostId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPost", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlogPost_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    InvitedByid = table.Column<int>(nullable: true),
                    Emailid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Emails_Emailid",
                        column: x => x.Emailid,
                        principalTable: "Emails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Users_InvitedByid",
                        column: x => x.InvitedByid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlogToKeywords",
                columns: table => new
                {
                    BlogId = table.Column<int>(nullable: false),
                    KeywordId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogToKeywords", x => new { x.BlogId, x.KeywordId });
                    table.ForeignKey(
                        name: "FK_BlogToKeywords_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogToKeywords_Keyword_KeywordId",
                        column: x => x.KeywordId,
                        principalTable: "Keyword",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PublishDateTime = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    AutherNameid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.id);
                    table.ForeignKey(
                        name: "FK_Article_Users_AutherNameid",
                        column: x => x.AutherNameid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticlePost",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PostId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    BlogId = table.Column<int>(nullable: false),
                    PostUserNameid = table.Column<int>(nullable: true),
                    Articleid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlePost", x => x.id);
                    table.ForeignKey(
                        name: "FK_ArticlePost_Article_Articleid",
                        column: x => x.Articleid,
                        principalTable: "Article",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticlePost_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticlePost_Users_PostUserNameid",
                        column: x => x.PostUserNameid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticleToKeywords",
                columns: table => new
                {
                    ArticleId = table.Column<int>(nullable: false),
                    KeywordId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleToKeywords", x => new { x.ArticleId, x.KeywordId });
                    table.ForeignKey(
                        name: "FK_ArticleToKeywords_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleToKeywords_Keyword_KeywordId",
                        column: x => x.KeywordId,
                        principalTable: "Keyword",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_AutherNameid",
                table: "Article",
                column: "AutherNameid");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlePost_Articleid",
                table: "ArticlePost",
                column: "Articleid");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlePost_BlogId",
                table: "ArticlePost",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlePost_PostUserNameid",
                table: "ArticlePost",
                column: "PostUserNameid");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleToKeywords_KeywordId",
                table: "ArticleToKeywords",
                column: "KeywordId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_BlogId",
                table: "BlogPost",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogToKeywords_KeywordId",
                table: "BlogToKeywords",
                column: "KeywordId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Emailid",
                table: "Users",
                column: "Emailid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_InvitedByid",
                table: "Users",
                column: "InvitedByid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Name",
                table: "Users",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlePost");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "ArticleToKeywords");

            migrationBuilder.DropTable(
                name: "BlogPost");

            migrationBuilder.DropTable(
                name: "BlogToKeywords");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Suggests");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Keyword");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Emails");
        }
    }
}
