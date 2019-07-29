using BLL.entity;
using Microsoft.EntityFrameworkCore;

namespace BLL.repoistory
{
    public class Repository<T> where T : Entity
    {
        public Repository()
        {
            CurrentContext = new SQLDBContext();
            entities = CurrentContext.Set<T>();
        }
        public SQLDBContext CurrentContext { get; set; }
        protected DbSet<T> entities { get; set; }
        public T Save(T entity)
        {
            CurrentContext.Add(entity);
            CurrentContext.SaveChanges();
            return entity;
        }
        public void Flush()
        {
            CurrentContext.SaveChanges();
        }
        //public T Get(int id)
        //{
        //    return entities.single(u => u.id == id);
        //}

    }
}