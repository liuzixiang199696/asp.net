using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace yuanzhan
{
    /*
     Test intention
     1.读取文件发生异常，（未读取到文件，文件只读。）
     2.邮箱地址不区分大小写。
     3.
         
         
         */
    class IO
    {
        private static string Path = @"G:\xiangmu\测试邮箱.txt";
        private static string Path1 = @"G:\xiangmu\测试邮箱1.txt";
        static string GetFromTxt()
        {

            string str = File.ReadAllText(Path);
            return str;
        }

        static string Filter()//过滤器
        {
            string str = GetFromTxt();
            str = str.ToLower();
            str = str.Replace(" ", "");
            return str;
        } 

      public  static string RemoveRepeatTest()
        {
            string str = Filter();
            string[] StrArr;
            StrArr = str.Split(';');
            Array.Sort(StrArr);
            StrArr = StrArr.Distinct().ToArray();
            string NewStr = string.Join("; ",StrArr);

            return NewStr;
        }   //移除重复

      public  static void SaveInGroup() {
            string str = RemoveRepeatTest();
            System.IO.File.WriteAllText(Path1, str, Encoding.Default);
        } //保存

    }
}
