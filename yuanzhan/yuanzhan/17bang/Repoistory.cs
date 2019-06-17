using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace assignment._17ban
{
    class TRepository<T> : IRepository<T> //仓库
    {
        private static IList<T> Trepository { get; }
        public  IList<T> SaveDocument()
        {
            XmlDocument doc = new XmlDocument();
            return Trepository;
        }

        public void Add(T repository)//增加内容
        {
            Trepository.Add(repository);
        }
        public void Remove(T repository)//删除内容
        {
            Trepository.Remove(repository);
        }
        public static IList<T> GetBy(string title)
        {
            
            return new List<T>();
        }
    }
}
