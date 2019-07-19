using BLL.Repoistory;
using Microsoft.EntityFrameworkCore;
using System;

namespace DBFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new SQLDBContext().Database.Migrate();
            RegisterFactory.Create();
            
        }
    }
}
