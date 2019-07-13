using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    interface IRepository<T>
    {
         IList<T> SaveDocument();
    }
}
