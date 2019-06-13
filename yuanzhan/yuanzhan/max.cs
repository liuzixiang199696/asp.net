using System;
using System.Collections.Generic;
using System.Text;

namespace yuanzhan
{
    class Seekmax : ISort
    {
        void ISort.sort(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
