using BLL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace assignment._17ban
{
    class Repository<T> where T :Entity
    {
        public T Save(T entity) { return entity; }
    }
}
