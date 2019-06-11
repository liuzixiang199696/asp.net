using System;
using System.Collections.Generic;
using System.Text;

namespace yuanzhan
{
    class GuessNumber
    {
        static void Guess()
        {
            int max = 1000;
            int random = new Random().Next(max);
            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("您还有{0}次机会输入", 10 - i);
                Console.WriteLine($"请输入你要猜的数字{max}以内");

                int number = Convert.ToInt32(Console.ReadLine());
                //int num = convert.ToInt32(Console.RedLine()）；
                // num = Console.Read();只能输入一个字符。
                if (number > random)
                {
                    Console.WriteLine("您猜大了！");
                }
                if (number < random)
                {
                    Console.WriteLine("您猜小了！");
                }
                if (number == random)
                {
                    Console.WriteLine("您猜中了！");
                    break;
                }
                Console.WriteLine("正确数字是" + random);
            }
        }
    }
}
