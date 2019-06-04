using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using OMDBAPI.Integration.Models;

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
         Task<JsonMovie> GetOMDBMovie(string movieTitle);
    }
}