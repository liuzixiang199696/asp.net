using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace yuanzhan.Xml
{
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
}
