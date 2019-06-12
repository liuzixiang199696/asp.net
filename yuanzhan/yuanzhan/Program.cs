using System;

namespace yuanzhan
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 8, 6, 4, 77 };
            ISort s = new maopao();
            s.sort(a);
        }
    }
    interface ISort
    {
        void sort(int[] a);
        
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





}
