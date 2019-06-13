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
            Bitmap image = new Bitmap(200, 100);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                int x1 = random.Next(image.Width);
                int y1 = random.Next(image.Height);
                int x2 = random.Next(image.Width);               
                int y2 = random.Next(image.Height);
                g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
            }
            for (int i = 0; i < 150; i++)
            {
                int x = random.Next(image.Width);
                int y = random.Next(image.Height);

                image.SetPixel(x, y, Color.FromArgb(random.Next()));
            }
            g.DrawString("hello", new Font("黑体",30),new SolidBrush(Color.Black),new PointF(40,30));
            image.Save(@"F:\\xiangmu\hello.jpg", ImageFormat.Jpeg);
        }
    }
}

