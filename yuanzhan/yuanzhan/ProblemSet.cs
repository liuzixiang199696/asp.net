using System;
using System.Collections.Generic;
using System.Text;

namespace yuanzhan
{
    public class ProblemSet
    {
        //1.输入一个字母，判断是大写还是小写字母
        public static void Q1()
        {

            Console.WriteLine("请输入一个字母 ");
            char ch = char.Parse(Console.ReadLine());
            if (ch >= 'a' && ch <= 'z')

            {

                Console.WriteLine("小写");

            }

            else

                Console.WriteLine("大写");

        }
        //2.用户输入三个整数，将最大数和最小数输出
        public static void Q2()
        {
            Console.WriteLine("请输入第一个数字");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字");
            int c = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(Math.Max(a, b), c);
            int min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine("最大值为" + max + "最小值为" + min);

        }
        //3.计算2.5的3次方
        public static void Q3()
        {
            double a = 2.5;
            double suma = a * a * a;
            Console.WriteLine(suma);
            Console.WriteLine(Math.Pow(2.5, 3));
        }
    }

}
