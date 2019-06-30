using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using yuanzhan._17bang;

namespace assignment._17ban
{
    [TokenManager]
    class User //用户
    {
        
        internal int Id { get; }
        internal string Name { get; set; }
        private string Password { get; }
        internal IList<Article> Articles { get; set; }
        internal IList<Comment> comment { get; set; }
        internal IList<Suggest> suggest { get; set; }
        internal IList<Problem> problem { get; set; }
        public User(string name)
        {
            Name = name;
        }
        internal static void users()
        {
            XElement element = new XElement("Users",
                new XElement("User1",
                new XElement("id", 1),
                new XElement("name", "feige"),
                new XElement("password", "123456")),
                new XElement("User2",
                new XElement("id", 2),
                new XElement("name", "laocheng"),
                new XElement("password", "1234567")),
                new XElement("User3",
                new XElement("id", 12),
                new XElement("name", "zixiang"),
                new XElement("password", "12345678"))
                );
            XDocument document = new XDocument(element);
            document.Save("G:\\xiangmu\\Users.xml");

        }
        //删除没有发表文章的用户
        internal static void DeleteUser()
        {
            XElement User = XElement.Load(" G:\\xiangmu\\Users.xml");
            XElement element = XElement.Load("G:\\xiangmu\\articles.xml");
        }


    }
}
