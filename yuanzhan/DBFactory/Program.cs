using BLL.repoistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;

namespace DBFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                @"Data Source=(localdb)\ProjectsV13;Initial Catalog=17bang;Integrated Security=True;";

            DbContextOptionsBuilder<SQLDBContext> optionsBuilder = new DbContextOptionsBuilder<SQLDBContext>();
            optionsBuilder
               .UseLoggerFactory(MyLoggerFactory)
               .UseSqlServer(connectionString);
            DatabaseFacade db = new SQLDBContext(optionsBuilder.Options).Database;
            db.EnsureDeleted();      //如果存在数据库，就删除之//db.EnsureCreated();   和Migration有可能冲突，不要混合使用
            db.Migrate();
            RegisterFactory.Create();
            
        }
        public static readonly LoggerFactory MyLoggerFactory
         = new LoggerFactory(
             new[]
             {
                    new ConsoleLoggerProvider((category, level) =>
                        category == DbLoggerCategory.Database.Command.Name &&
                        level == LogLevel.Information
                    , true)
             });
    }
}
