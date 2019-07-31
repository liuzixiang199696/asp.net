using BLL.entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BLL.repoistory
{
    public class Repository<T> where T : Entity
    {
        public SQLDbContext CurrentContext { get; set; }
        public DbSet<T> entities { get; set; }
        public Repository(SQLDbContext context)
        {
            CurrentContext = context;
            entities = CurrentContext.Set<T>();
        }

        public Repository(Microsoft.EntityFrameworkCore.DbContext context)
        {
        }

        public void SetEntities(SQLDbContext context)
        {
            CurrentContext = context;
            entities = CurrentContext.Set<T>();
        }
        public virtual T Save(T entity)
        {
            CurrentContext.Add(entity);
            CurrentContext.SaveChanges();
            return entity;
        }
        public void Flush()
        {
            CurrentContext.SaveChanges();
        }
        public virtual T Get(int id)
        {
            return entities.Where(u => u.id == id).SingleOrDefault();
        }

    }
}