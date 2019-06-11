using System;
using System.Collections.Generic;
using System.Text;

namespace yuanzhan
{
    class maopao
    {
        static void Sort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {

                //内循环，冒泡排序，
                for (int k = 0; k < a.Length - 1 - i; k++)
                {
                    if (a[k] > a[k + 1])
                    {
                        //赋值
                        int c;
                        c = a[k];
                        a[k] = a[k + 1];
                        a[k + 1] = c;
                    }
                }
            }
            for (int j = 0; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);
            }
        }
    }
}
