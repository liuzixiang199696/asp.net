using System;
using System.Collections.Generic;
using System.Text;

namespace yuanzhan
{
    class SeekMaximumValue
    {
        static void max(int[] a)
        { 
            for (int i = 0; i < a.Length; i++)
            {
                //数组的遍历
                Console.WriteLine("第{0}个数组中的数字为{1}", i + 1, a[i]);
            }
            //求最大值
            int max = a[0];
            for (int z = 0; z < a.Length; z++)
            {
                //把最大值赋值给max
                if (max < a[z])
                {
                    max = a[z];
                }
            }
            Console.WriteLine("最大值为:{0}", max);


        }
    }
}
