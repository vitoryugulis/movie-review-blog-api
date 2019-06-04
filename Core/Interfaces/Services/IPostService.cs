using System.Collections.Generic;
using Core.Models;

namespace Core.Interfaces.Services
{
    public interface IPostService
    {
         IEnumerable<Post> GetAll();
         Post GetById(int id);
         void Update(Post post);
         void Remove(Post post);
         void Add(Post post);
         bool CheckIfExists(int id);
    }
}