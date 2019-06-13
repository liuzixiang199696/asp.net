using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
namespace VerificationCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Vfcode();
        }
        static void Vfcode()
        {
            Bitmap image = new Bitmap(200, 100);//生成画布
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);//绘画背景颜色
            Random random = new Random();//随机生成器
                                         // 绘画噪音线
            for (int i = 0; i < 20; i++)
            {
                int x1 = random.Next(image.Width);
                int y1 = random.Next(image.Height);
                int x2 = random.Next(image.Width);
                int y2 = random.Next(image.Height);
                g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
            }
            // 绘画噪音点
            for (int i = 0; i < 150; i++)
            {
                int x = random.Next(image.Width);
                int y = random.Next(image.Height);

                image.SetPixel(x, y, Color.FromArgb(random.Next()));
            }
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
            foreach (string s in str)//遍历赋值
            {
                serverCode += s;
            }
            g.DrawString(serverCode, new Font("黑体", 30), new SolidBrush(Color.Black), new PointF(40, 30));
            image.Save(@"F:\\xiangmu\hello.jpg", ImageFormat.Jpeg);
        }

    }
}

