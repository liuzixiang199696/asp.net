using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace yuanzhan
{
    class IO
    {
        private static string Path = @"G:\xiangmu\测试邮箱.txt";

        static string GetFromTxt(string Path)
        {
            string str = File.ReadAllText(Path);
            return str;
        }

        static string Filter()//过滤器
        {


            return null;
        } //过滤器

        static string RemoveRepeatTest()
        {
            return null;
        }   //移除重复

        static void SaveInGroup() { } //保存

    }
}
