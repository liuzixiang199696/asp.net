using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace yuanzhan.Xml
{
    class SELECT
    {
       static string APash = "G:\\xiangmu\\articles.xml";
        static string UPash = "G:\\xiangmu\\Users.xml";
        //根据用户名查找他发布的全部文章
        internal static void UserAllArticles()
        {
            XElement element = XElement.Load(APash);
            var query = element.Descendants("article").Where(W => W.Element("id").Value == 1.ToString());
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
        //统计出每个用户各发表了多少篇文章
        internal static void FindArticles()
        {
            XElement element = XElement.Load(APash);
            var query = element.Descendants("article").Where(W => W.Element("id").Value == 1.ToString()).Count();
            Console.WriteLine(query);
        }
        //查出每个用户最近发布的一篇文章
        internal static void UserRecentlyPublishedArticles()
        {
            XElement element = XElement.Load(APash);
        }
        //每个用户评论最多的一篇文章
        internal static void MostUserComments()
        {
            XElement element = XElement.Load(APash);
            var query = element.Elements("article").Elements("comments").Descendants("comment");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }
        //删除没有发表文章的用户
        internal static void DeleteUser()
        {
            XElement User = XElement.Load(UPash);
            XElement element = XElement.Load(APash);
        }
    }
}
