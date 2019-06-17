using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment._17ban
{
    class TRepository<T> : IRepository<T>
    {
        private static IList<T> Trepository { get; }
        public  IList<T> Get()
        {
            return Trepository;
        }

        public void Add(T repository)
        {
            Trepository.Add(repository);
        }
        public static IList<T> GetBy(string title)
        {
            
            return new List<T>();
        }
    }
}
