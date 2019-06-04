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
        public void AddPost(TEntity entity)
        {
            db.Add(entity);
            db.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            db.Remove(entity);
            db.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            db.Update(entity);
            db.SaveChanges();
        }
    }
}