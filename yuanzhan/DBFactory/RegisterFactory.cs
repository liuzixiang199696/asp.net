using BLL;
using BLL.Repoistory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    /// <summary>
    /// 工厂模式
    /// </summary>
    internal class RegisterFactory
    {
        internal static MYUser zhangsan, wangwu;
        private static UserRepoistory _userPepo; 
        static RegisterFactory()
        {
            _userPepo = new UserRepoistory();
        }
        internal static void Create()
        {
            zhangsan = register("张三");
            wangwu = register("王五");


        }
        private static MYUser register(string name)
        {
            MYUser user = new MYUser { Name = name, Password = Helper.PASSWORD };
            user.Register(zhangsan);
            user.Register(zhangsan);
            return user;
        }
    }
}
