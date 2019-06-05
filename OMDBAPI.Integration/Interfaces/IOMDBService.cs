using System.Threading.Tasks;
using OMDBAPI.Integration.Models;

namespace OMDBAPI.Integration.Interfaces
{
    public interface IOMDBService
    {
         Task<JsonMovie> GetMovieByTitle(string movieTitle);
    }
}