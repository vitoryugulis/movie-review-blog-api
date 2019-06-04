using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOS;
using AutoMapper;
using Core.Interfaces.Services;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using OMDBAPI.Integration.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Produces("application/json")]
    public class PostsController : ControllerBase
    {

        // GET api/posts/
        [HttpGet]
        public IActionResult GetAll([FromServices] IPostService service)
        {
            var posts = service.GetAll();
            return Ok(posts);
        }

        // GET api/posts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromServices] IMapper mapper, [FromServices] IPostService service, int id)
        {
            var post = service.GetById(id);
            if (post == null)
            {
                return NotFound();
            }
            var omdbMovie = await service.GetOMDBMovie(post.MovieName);
            var postDTO = mapper.Map<Post, PostDTO>(post);
            postDTO.ImdbInfo = omdbMovie;
            return Ok(postDTO);
        }

        // POST api/posts
        [HttpPost]
        public IActionResult Post([FromServices] IMapper mapper, [FromServices] IPostService service, [FromBody] PostDTO dto)
        {
            var post = mapper.Map<PostDTO, Post>(dto);
            service.Add(post);
            return Ok(post);
        }

        // PUT api/posts/5
        [HttpPut("{id}")]
        public IActionResult Put([FromServices] IMapper mapper, [FromServices] IPostService service, [FromBody] PostDTO dto, int id)
        {
            if(!service.CheckIfExists(id) || id != dto.Id)
            {
                return NotFound();
            }
            var post = mapper.Map<PostDTO, Post>(dto);
            service.Update(post);
            return Ok(post);
        }

        // DELETE api/posts/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromServices] IPostService service, int id)
        {
            var post = service.GetById(id);
            if (post == null)
            {
                return NotFound();
            }
            service.Remove(post);
            return Ok();
        }
    }
}