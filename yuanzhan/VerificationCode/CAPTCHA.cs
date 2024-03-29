﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.CodeDom;
using System.IO;
using System.Xml.Linq;
using System.Threading;

namespace VerificationCode
{
    class Captcha
    {

       static Func<Bitmap> GenerateCanvas = () =>//生成画布
        {
            Random random = new Random();
            Bitmap image = new Bitmap(200, 100);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.FromArgb(random.Next()));
            return image;
        };
        static Func<Bitmap> AddNoiseLine = () =>//绘画噪音线
        {
            Task<Bitmap> image2 = Task.Run(GenerateCanvas);
            Random random = new Random();//随机生成器
            for (int i = 0; i < 20; i++)
            {
                int x1 = random.Next(image2.Result.Width);
                int y1 = random.Next(image2.Result.Height);
                int x2 = random.Next(image2.Result.Width);
                int y2 = random.Next(image2.Result.Height);
                Graphics g = Graphics.FromImage(image2.Result);
                g.DrawLine(new Pen(Color.FromArgb(random.Next())), x1, y1, x2, y2);
            }
            Console.WriteLine($"Task-{Task.CurrentId}" +
                     $"ThreadId:{Thread.CurrentThread.ManagedThreadId}");
            return image2.Result;
        };
        static Func<Bitmap> AddNoisePoint = () =>// 绘画噪音点
        {

            Task<Bitmap> image3 = Task.Run(AddNoiseLine);
            Random random = new Random();//随机生成器
            for (int i = 0; i < 150; i++)
            {
                int x = random.Next(image3.Result.Width);
                int y = random.Next(image3.Result.Height);
                image3.Result.SetPixel(x, y, Color.FromArgb(random.Next()));
            }
            Console.WriteLine($"Task-{Task.CurrentId}" +
                    $"ThreadId:{Thread.CurrentThread.ManagedThreadId}");
            return image3.Result;
        };
       
        static Bitmap GenerateFerificationCode()//生成验证码
        {
            try
            {
                Task<Bitmap> image4 = Task.Run(AddNoisePoint);
                Random random = new Random();//随机生成器
                string[] str = new string[4];//定义验证码长度
                string serverCode = "";//装验证码
                string[] a = new string[62] { "0", "1", "2", "3", "4", "5",
                "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G",
                "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
                "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c",
                "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n",
                "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                for (int i = 0; i < 4; i++)
                {
                    str[i] = a[random.Next(62)];
                }
                if (str[0] == str[1] || str[0] == str[2] ||
                    str[0] == str[3] || str[1] == str[2] ||
                    str[1] == str[3] || str[2] == str[3])
                {
                    throw new NotImplementedException("生成随机数重复！");
                }
                foreach (string s in str)//遍历赋值
                {
                    serverCode += s;
                }
                Graphics g = Graphics.FromImage(image4.Result);
                g.DrawString(serverCode, new Font("黑体", 30), new SolidBrush(Color.FromArgb(random.Next())), new PointF(40, 30));
                Console.WriteLine($"Task-{Task.CurrentId}"+
                    $"ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                return image4.Result;
            }
            catch (Exception e)
            {
                File.AppendAllText("G:\\xiangmu\\zx-error.log",
                   $"{DateTime.Now}：生成验证码重复" + e.ToString() + Environment.NewLine);
                throw new InvalidCastException($"生成验证码重复", e);
            }

        }
        public static void Call()//调用
        {
            try
            {
                Action action = () =>
                {
                    GenerateFerificationCode().Save(@"G:\\xiangmu\hello.jpg", ImageFormat.Jpeg);
                };
                Task t1 = Task.Run(action);
                Process.Start(@"G:\\xiangmu\hello.jpg");
            }
            catch (Exception e)
            {
                File.AppendAllText("G:\\xiangmu\\zx-error.log",
                   $"{DateTime.Now}：" + e.ToString() + Environment.NewLine);
                Console.WriteLine("程序遇到了未处理的异常情况，请重新生成验证码，ごめんね。");
                Console.WriteLine();
            }
        }
    }
}
