using System;
using System.Collections;
using System.Reflection.Metadata;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace yuanzhan
{
    class Program
    {
        static void Main(string[] args)
        {
          var  a =   new GuessNumber();
            a.Guess();

        }

    }
    class User {
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
    class Article
    {
        internal static void articles()
        {
            XElement articles = new XElement(
                "articles",
                new XComment("以下存放所有“源栈”所有文章"),
                new XElement("article", new XAttribute("isDraft", false),
                    new XElement("id", 1),
                    new XElement("title", "源栈培训：C#进阶-7：Linq to XML"),
                    new XElement("body", "什么是XML（EXtensible Markup Language）是一种文本文件格式被设计用来传输和存储数据由：标签和属性组成元素（节点），由元素组成“树状结构”必须有而且只能有一个根节点其他："),
                    new XElement("authorId", 1),
                    new XElement("publishDate", "2019/6/18 18:15"),
                    new XElement("comments",
                        new XElement("comment", new XAttribute("recommend", "true"),
                            new XElement("id", 12),
                            new XElement("body", "不错，赞！"),
                            new XElement("authorId", 2)
                            )
                        )
                    ), new XElement("article", new XAttribute("isDraft", false),
                    new XElement("id", 1),
                    new XElement("title", "源栈培训：C#进阶-7：Linq to XML"),
                    new XElement("body", "什么是XML（EXtensible Markup Language）是一种文本文件格式被设计用来传输和存储数据由：标签和属性组成元素（节点），由元素组成“树状结构”必须有而且只能有一个根节点其他："),
                    new XElement("authorId", 1),
                    new XElement("publishDate", "2019/6/18 18:15"),
                    new XElement("comments",
                        new XElement("comment", new XAttribute("recommend", "true"),
                            new XElement("id", 12),
                            new XElement("body", "不错，赞！"),
                            new XElement("authorId", 2)
                            ),
                        new XElement("comment", new XAttribute("recommend", "true"),
                            new XElement("id", 12),
                            new XElement("body", "不错，赞！"),
                            new XElement("authorId", 2)
                            )
                        )
                    ),
                new XElement("article", new XAttribute("isDraft", true),
                    new XElement("id", 2),
                    new XElement("title", "源栈培训：C#进阶-6：异步和并行"),
                    new XElement("authorId", 1)
                    )
                );
            articles.Add(new XElement("article", new XElement("id"),
                new XElement("title"), new XElement("authorId"))
              );
            var query = articles.Element("article").Element("comments").
                Descendants("comment").Where(w => w.Element("id").Value == 12.ToString());
           // query.Remove();
            var query1 = articles.Elements("article").Where(w => w.Element("id").Value == 2.ToString()).Single();
            query1.SetAttributeValue("isDraft", false);
            query1.SetElementValue("title", "源栈培训：C#进阶-8：异步和并行");
            //articles.Element("article").Elements
            XDocument document = new XDocument(articles);
            document.Save("G:\\xiangmu\\articles.xml");
        }
       
       

    }
    class SELECT {
        //根据用户名查找他发布的全部文章
        internal static void UserAllArticles()
        {
            XElement element = XElement.Load("G:\\xiangmu\\articles.xml");
            var query = element.Descendants("article").Where(W => W.Element("id").Value == 1.ToString());
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
        //统计出每个用户各发表了多少篇文章
        internal static void FindArticles()
        {
            XElement element = XElement.Load("G:\\xiangmu\\articles.xml");
            var query = element.Descendants("article").Where(W => W.Element("id").Value == 1.ToString()).Count();
            Console.WriteLine(query);
        }
        //查出每个用户最近发布的一篇文章
        internal static void UserRecentlyPublishedArticles()
        {
            XElement element = XElement.Load("G:\\xiangmu\\articles.xml");
        }
        //每个用户评论最多的一篇文章
        internal static void MostUserComments()
        {
            XElement element = XElement.Load("G:\\xiangmu\\articles.xml");
            var query = element.Elements("article").Elements("comments").Descendants("comment");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }
        //删除没有发表文章的用户
        internal static void DeleteUser()
        {
            XElement User = XElement.Load(" G:\\xiangmu\\Users.xml");
            XElement element = XElement.Load("G:\\xiangmu\\articles.xml");
        }
    }
    //interface Ischool
    //{

    //    void learn();
    //    void rest();
    //}
    //interface Ilibrary
    //{
    //    void learn();
    //    void rest();
    //}

    //public class people :IEnumerable, IEnumerator
    //{
    //    public object Current => throw new NotImplementedException();

    //    public IEnumerator GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool MoveNext()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Reset()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //internal class Major
    //{
    //    public string name = "c#";
    //}
    //internal class sql : Major
    //{
    //    // public string name = "sql";
    //}
    //internal class Person<T> where T : Major
    //{
    //    public Person()
    //    {

    //    }
    //}
    //internal class Teacher<T> : Person<T> where T : Major
    //{


    //}
}
