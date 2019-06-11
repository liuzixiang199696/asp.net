using System;
using System.Collections.Generic;
using System.Text;

namespace yuanzhan
{
   public class BinarySearch
    {
       public static void Query()
        {
            //生成一个固定数组
            // int[] array =new int[] {1,13,45,78,98,111,133,144,199,210,230 };
            //更新： 生成了一个完全随机且有序数组，（初始值也随机）。
            int Length = 10;//指定数组长度。
            int[] array = new int[Length];
            array[0] = new Random().Next(15, 500);//初始值随机。
                                                  //每次数组值增加随机。
            for (int i = 0; i < Length - 1; i++)
            {

                array[i + 1] = array[i] + new Random().Next(10, 5000);
            }
            //打印查看。
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"现有数据为:{array[i]}" + "      ");

            }

            Console.WriteLine("请输入您要查询的数字:");
            //index  = 数组的最大位数，
            int index = array.Length - 1;//右边界
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                // steps = 数组中间角标值，
                int steps = (index + 1) / 2;
                /*若一次猜中， input = array[index]，结束，break，
                 若猜测得数大于中间数， index += steps ====  index = index + steps ;
                 若猜测得数小于中间数， index -= steps ====  index = index - steps ;
                 */
                while (input == array[index])
                {
                    Console.WriteLine("找到了" + array[index]);
                    Console.WriteLine($"第{i + 1}查找，取第{index},值为{array[index]}"); 
                }
                while (input > array[index])
                {
                    Console.WriteLine($"第{i + 1}查找，取第{index},值为{array[index]}");
                    index = steps + index;
                }
                while (input < array[index])
                {
                    Console.WriteLine($"第{i + 1}查找，取第{index},值为{array[index]}");
                    index = index - steps;
                }
            }

        }
    }
}
