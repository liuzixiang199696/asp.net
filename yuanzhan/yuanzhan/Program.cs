using System;
using System.Collections;

namespace yuanzhan
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Action<int, int> calculate = (x, y) =>
            ////{ Console.WriteLine($"hello,{x}+{y}"); };
            ////Func<int, int, int> lzx = (int x, int y) => { return x + y; };
            //Person<Major> P = new Person<Major>();
            //P = new Teacher<Major>();
            people people = new people();
            foreach (var item in people)
            {

            }

        }

    }


    interface Ischool
    {

        void learn();
        void rest();
    }
    interface Ilibrary
    {
        void learn();
        void rest();
    }

    public class people :IEnumerable, IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

    internal class Major
    {
        public string name = "c#";
    }
    internal class sql : Major
    {
        // public string name = "sql";
    }
    internal class Person<T> where T : Major
    {
        public Person()
        {

        }
    }
    internal class Teacher<T> : Person<T> where T : Major
    {


    }
}
