﻿using BLL.entity.Articled;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.repoistory
{
    public class SQLDbContext :DbContext
    {
        //public SQLDbContext(DbContextOptions<SQLDbContext> options) : base(options)
        //{

        //}
        //public static readonly LoggerFactory MyLoggerFactory
        //= new LoggerFactory(new[]
        //{
        //      new ConsoleLoggerProvider((_, __) => true, true) }
        //);
        public DbSet<Suggest> Suggests { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<MYUser> users { get; set; }
        public DbSet<Email> emails { get; set; }
        public DbSet<Message> messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=17bang;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder
            //   .UseLoggerFactory(MyLoggerFactory)
            //   .UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MYUser>().HasIndex(u=>u.Name).IsUnique();
            modelBuilder.Entity<MYUser>((options) => { options.ToTable("Users").Property(x => x.Name).IsRequired(); });
            modelBuilder.Entity<Blog>((options) => { options.Ignore(x => x.Url); });
            modelBuilder.Entity<BlogToKeywords>()
                .HasKey(bk => new { bk.BlogId, bk.KeywordId });
            //modelBuilder.Entity<Article>().HasDiscriminator(b => b.DiscriminatorType);
            modelBuilder.Entity<Suggest>();
                //.HasIndex(b => b.id)
                //.IsUnique();
        }


    }
}
