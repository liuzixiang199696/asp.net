using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
   public class UserHelper
    {
        private static DataTable _Users = new DataTable();
        /// <summary>
        /// 在数据库进行查找，根据用户名获取用户ID
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns>如果找到返回id，否则返回NULL，</returns>
        public int? GetByName(string name)
        {

            return null;
        }
        public void Save(string name, string password)
        {

        }

    }
}
