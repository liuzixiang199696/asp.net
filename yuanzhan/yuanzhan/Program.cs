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
            studect studect = new studect();
            string lzx = "lzx";
            Console.WriteLine(studect.ninchilema(lzx)); 
        }
      

    }

    // class student 学生类，  public 公开的，private, 私有的 ，修饰符  static , 静态的 ,eat方法名，
    // () 参数  void, 返回值 ， int string ,bool,   return返回
    class studect
    {
        public void eat(string zhongcan)
        {
            Console.WriteLine("我吃的是"+zhongcan);
        }
        public string ninchilema(string student)
        {
            if (student=="lzx")
            {
                string q = "吃了";
                return q;
            }
            else
            {
                string b = "没吃";
                return b;
            }
            
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
