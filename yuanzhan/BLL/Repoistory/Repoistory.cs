using BLL.entity;
using Microsoft.EntityFrameworkCore;

namespace BLL.repoistory
{
    public class Repository<T> where T : Entity
    {
        public SQLDBContext CurrentContext { get; set; }
        public DbSet<T> entities { get; set; }
        public Repository()
        {
            CurrentContext = new SQLDBContext();
            entities = CurrentContext.Set<T>();
        }
        public void SetEntities(SQLDBContext context)
        {
            CurrentContext = context;
            entities = CurrentContext.Set<T>();
        }
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