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
            //    Article xml = new Article();
            //    Article.articles();
            //    XElement element = XElement.Load("G:\\xiangmu\\articles.xml");
            //    Console.WriteLine(element);
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(5);
                Task<DateTime> getup =  Task<DateTime>.Run(() =>
                {
                    Console.WriteLine($"Task-{Task.CurrentId}：起床啦！...." +
                        $"ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                    return DateTime.Now;
                });

                getup.ContinueWith((x) =>
                {
                    Console.WriteLine($"{x.Result}起床结束");
                    Console.WriteLine($"Task-{Task.CurrentId}：刷牙洗脸...." +
                        $"ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                });

            }
            Console.ReadLine();
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
