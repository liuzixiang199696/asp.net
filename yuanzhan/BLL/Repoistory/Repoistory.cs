using BLL.entity;
using Microsoft.EntityFrameworkCore;

namespace BLL.repoistory
{
   public class Repository<T> where T : Entity
    {
        public SQLDBContext CurrentContext { get; set; }
        protected DbSet<T> entities { get; set; }
        public T Save(T entity) { return entity; }
        public Repository()
        {
            CurrentContext = new SQLDBContext();
            entities = CurrentContext.Set<T>();
        }

    }
}