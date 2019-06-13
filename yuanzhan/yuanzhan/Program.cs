using System;

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

    class people : Ischool, Ilibrary
    {
        void Ischool.learn()
        {
            throw new NotImplementedException();
        }

        void Ilibrary.learn()
        {
            throw new NotImplementedException();
        }

        void Ischool.rest()
        {
            throw new NotImplementedException();
        }

        void Ilibrary.rest()
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
