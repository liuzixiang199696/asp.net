using System;
using System.Collections.Generic;
using System.Text;

namespace yuanzhan._17bang
{
    //查找源代码，说明：为什么标记为[Flags] 的枚举在Console.WriteLine()时可以输入“Student,TeacherAssist”的效果。
    /*        [Flags]
            public enum Flags
            {
                Zero = 0,
                SCH_CRED_NO_SYSTEM_MAPPER = 0x02,
                SCH_CRED_NO_SERVERNAME_CHECK = 0x04,
                SCH_CRED_MANUAL_CRED_VALIDATION = 0x08,
                SCH_CRED_NO_DEFAULT_CREDS = 0x10,
                SCH_CRED_AUTO_CRED_VALIDATION = 0x20,
                SCH_SEND_AUX_RECORD = 0x00200000,
                SCH_USE_STRONG_CRYPTO = 0x00400000,
            }
    Flag 特性微软的解释是：指示可以将枚举作为位域
    （即一组标志）处理，FlagsAttribute属性就是枚举类型的一项可选属性，
    它的主要作用是可以将枚举作为位域处理(P.S.C#不支持位域)。
    所谓位域是单个存储单元内相邻二进制位的集合。通过为枚举添加这个属性，
    可以改变枚举的一些行为来满足我们的需要。*/
    //声明一个权限（Token）枚举，用[Flags] 标记，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
    [Flags]
    internal enum Token
    {
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 4,
        Newbie = 8,
        Registered = 16,
    }
    // 声明一个权限管理（TokenManager）类，
    //可作为此前User类的属性，使用私有的Token枚举_tokens存储所具有的权限，
    //具有Add(Token)、Remove(Token)和Has(Token)方法，可以添加删除查看其权限
    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    internal  class TokenManagerAttribute : Attribute
    {
    internal void Add(Token token) { }
        internal void Remove(Token token) { }
        internal void Has(Token token) { }

    }
}
