using System;
using System.Collections.Generic;
using System.Text;

namespace yuanzhan
{
    class Generics
    {
        private String _name;
        public Generics(string name)
        {
            _name = name;
        }
        static void call()
        {
            Console.WriteLine("call");
            object a = "as";
            object b = 23;
            Swap(ref a, ref b );
        }
        void Swap<T>(ref T a, ref T b) where T :struct
        {
            
        }
        static void Swap(ref int a, ref int b) 
        {
            Console.WriteLine();
        }
        static void Swap(ref object a, ref object b)
        {

        }

    }
}
