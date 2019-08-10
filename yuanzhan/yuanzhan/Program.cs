using System;
using System.Collections;
using System.Reflection.Metadata;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Threading.Tasks;
using yuanzhan.Xml;
namespace yuanzhan
{
    class Program
    {
        static void Main(string[] args)
        {
            


        }
        public static async void Getup()
        {
            Console.WriteLine($"before await-1 with thread {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"before await-2 with thread {Thread.CurrentThread.ManagedThreadId}");
            //await 之前的代码，在主线程上运行

            //await 开始异步执行，方法从这里开始返回调用者
            await Task.Run(() =>
            {
                Console.WriteLine($"in await with thread {Thread.CurrentThread.ManagedThreadId}");
            });

            //直到await中内容执行完毕，才开始（但不是立即或同步的）执行await之后的代码
            Console.WriteLine($"after await-3 with thread {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"after await-4 with thread {Thread.CurrentThread.ManagedThreadId}");
        }

    }


    class studect
    {
        public void sj(int a)
        {
            Console.WriteLine(a);
        }
        public String kj { get; set; }
        public void a() { Console.WriteLine("a"); }
        public void b() { Console.WriteLine("b"); }
        public void c() { Console.WriteLine("c"); }

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
