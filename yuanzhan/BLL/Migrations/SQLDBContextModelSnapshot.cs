﻿// <auto-generated />
using System;
using BLL.repoistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BLL.Migrations
{
    [DbContext(typeof(SQLDbContext))]
    partial class SQLDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BLL.Article", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<string>("DiscriminatorType");

                    b.Property<DateTime>("PublishSuggestDateTime");

                    b.Property<string>("Title");

                    b.HasKey("id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("BLL.Email", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime?>("EmailHasValidated");

                    b.Property<int>("OwnerId");

                    b.Property<string>("ValidationCode");

                    b.HasKey("id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("BLL.entity.Articled.Article", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AutherNameid");

                    b.Property<string>("Body");

                    b.Property<DateTime>("PublishDateTime");

                    b.Property<string>("Title");

                    b.HasKey("id");

                    b.HasIndex("AutherNameid");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("BLL.entity.Articled.Article+ArticlePost", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Articleid");

                    b.Property<int>("BlogId");

                    b.Property<string>("Content");

                    b.Property<int>("PostId");

                    b.Property<int?>("PostUserNameid");

                    b.Property<string>("Title");

                    b.HasKey("id");

                    b.HasIndex("Articleid");

                    b.HasIndex("BlogId");

                    b.HasIndex("PostUserNameid");

                    b.ToTable("ArticlePost");
                });

            modelBuilder.Entity("BLL.entity.Articled.ArticleToKeywords", b =>
                {
                    b.Property<int>("ArticleId");

                    b.Property<int>("KeywordId");

                    b.HasKey("ArticleId", "KeywordId");

                    b.HasIndex("KeywordId");

                    b.ToTable("ArticleToKeywords");
                });

            modelBuilder.Entity("BLL.entity.Articled.Blog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("PublishSuggestDateTime");

                    b.Property<string>("Title");

                    b.HasKey("id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("BLL.entity.Articled.BlogPost", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId");

                    b.Property<string>("Content");

                    b.Property<int>("PostId");

                    b.Property<string>("Title");

                    b.HasKey("id");

                    b.HasIndex("BlogId");

                    b.ToTable("BlogPost");
                });

            modelBuilder.Entity("BLL.entity.Articled.BlogToKeywords", b =>
                {
                    b.Property<int>("BlogId");

                    b.Property<int>("KeywordId");

                    b.HasKey("BlogId", "KeywordId");

                    b.HasIndex("KeywordId");

                    b.ToTable("BlogToKeywords");
                });

            modelBuilder.Entity("BLL.entity.Articled.Keyword", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<string>("Name");

                    b.Property<DateTime>("PublishSuggestDateTime");

                    b.Property<string>("Title");

                    b.HasKey("id");

                    b.ToTable("Keyword");
                });

            modelBuilder.Entity("BLL.entity.Articled.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Context");

                    b.Property<DateTime>("PublishMessageTime");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("BLL.MYUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Emailid");

                    b.Property<int?>("InvitedByid");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.HasKey("id");

                    b.HasIndex("Emailid");

                    b.HasIndex("InvitedByid");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BLL.Suggest", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutherId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("PublishSuggestDateTime");

                    b.Property<string>("Title");

                    b.HasKey("id");

                    b.ToTable("Suggests");
                });

            modelBuilder.Entity("BLL.entity.Articled.Article", b =>
                {
                    b.HasOne("BLL.MYUser", "AutherName")
                        .WithMany()
                        .HasForeignKey("AutherNameid");
                });

            modelBuilder.Entity("BLL.entity.Articled.Article+ArticlePost", b =>
                {
                    b.HasOne("BLL.entity.Articled.Article")
                        .WithMany("Posts")
                        .HasForeignKey("Articleid");

                    b.HasOne("BLL.entity.Articled.Blog", "Blog")
                        .WithMany()
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BLL.MYUser", "PostUserName")
                        .WithMany()
                        .HasForeignKey("PostUserNameid");
                });

            modelBuilder.Entity("BLL.entity.Articled.ArticleToKeywords", b =>
                {
                    b.HasOne("BLL.entity.Articled.Article", "Article")
                        .WithMany("Keywords")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BLL.entity.Articled.Keyword", "Keyword")
                        .WithMany("Articles")
                        .HasForeignKey("KeywordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BLL.entity.Articled.BlogPost", b =>
                {
                    b.HasOne("BLL.entity.Articled.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BLL.entity.Articled.BlogToKeywords", b =>
                {
                    b.HasOne("BLL.entity.Articled.Blog", "Blog")
                        .WithMany("Keywords")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BLL.entity.Articled.Keyword", "Keyword")
                        .WithMany("Blogs")
                        .HasForeignKey("KeywordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BLL.MYUser", b =>
                {
                    b.HasOne("BLL.Email", "Email")
                        .WithMany()
                        .HasForeignKey("Emailid");

                    b.HasOne("BLL.MYUser", "InvitedBy")
                        .WithMany()
                        .HasForeignKey("InvitedByid");
                });
#pragma warning restore 612, 618
        }
    }
}
