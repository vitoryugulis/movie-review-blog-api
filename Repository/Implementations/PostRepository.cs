using System.Collections.Generic;
using System.Linq;
using Core.Interfaces.Repositories;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace Repository.Implementations
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public override IEnumerable<Post> GetAll()
        {
            return db.Posts.Include(x => x.Comments).ToList();
        }

        public override Post GetById(int id)
        {
            return db.Posts.Include(x => x.Comments).SingleOrDefault(x => x.Id == id);
        }
    }
}