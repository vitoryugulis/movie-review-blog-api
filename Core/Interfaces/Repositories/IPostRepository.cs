using System.Collections.Generic;
using Core.Models;

namespace Core.Interfaces.Repositories
{
    public interface IPostRepository : IBaseRepository<Post>
    {
         bool CheckIfExists(int id);
    }
}