using System.Collections.Generic;
using Core.Models;

namespace Core.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void Add(TEntity entity);
    }
}