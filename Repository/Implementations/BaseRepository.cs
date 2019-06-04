using System.Collections.Generic;
using System.Linq;
using Core.Interfaces.Repositories;
using Repository.Context;

namespace Repository.Implementations
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly BlogContext db;

        public BaseRepository()
        {
            this.db = new BlogContext();
        }
        public virtual void Add(TEntity entity)
        {
            db.Add(entity);
            db.SaveChanges();
        }

        public virtual void Remove(TEntity entity)
        {
            db.Remove(entity);
            db.SaveChanges();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public virtual void Update(TEntity entity)
        {
            db.Update(entity);
            db.SaveChanges();
        }
    }
}