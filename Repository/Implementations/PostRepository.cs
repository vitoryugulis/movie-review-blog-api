using System.Collections.Generic;
using Core.Interfaces.Repositories;
using Core.Models;
using Repository.Context;

namespace Repository.Implementations
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
    }
}