using System.Collections.Generic;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;

namespace Core.Services
{
    public class PostService : IPostService
    {

        private readonly IPostRepository postRepository;

        public PostService(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }
        public void Create(Post post)
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

        public void Remove(Post post)
        {
            postRepository.Remove(post);
        }

        public void Update(Post post)
        {
            postRepository.Update(post);
        }
    }
}