using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;
using OMDBAPI.Integration.Interfaces;
using OMDBAPI.Integration.Models;

namespace Core.Services
{
    public class PostService : IPostService
    {

        private readonly IPostRepository postRepository;
        private readonly IOMDBService omdbService;

        public PostService(IPostRepository postRepository, IOMDBService omdbService)
        {
            this.postRepository = postRepository;
            this.omdbService = omdbService;
        }
        public void Add(Post post)
        {
            postRepository.Add(post);
        }

        public IEnumerable<Post> GetAll()
        {
            return postRepository.GetAll();
        }

        public Post GetById(int id)
        {
            return postRepository.GetById(id);
        }

        public async Task<JsonMovie> GetOMDBMovie(string movieTitle){
            var result = await omdbService.GetMovieByTitle(movieTitle);
            return result;
        }

        public void Remove(Post post)
        {
            postRepository.Remove(post);
        }

        public void Update(Post post)
        {
            postRepository.Update(post);
        }

        public bool CheckIfExists(int id)
        {
            return postRepository.CheckIfExists(id);
        }
    }
}