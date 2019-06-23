using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace yuanzhan.Xml
{
    class User
    {
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
    }
}
