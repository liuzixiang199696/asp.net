using SRV;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    internal class RegisterFactory
    {
        private static RegisterService _registerservice;
        static RegisterFactory()
        {
            _registerservice = new RegisterService();
        }
        internal static void Create()
        {
           _registerservice.Register("张三",Helper.PASSWORD);
            _registerservice.Register("李四", Helper.PASSWORD);
        }
    }
}
