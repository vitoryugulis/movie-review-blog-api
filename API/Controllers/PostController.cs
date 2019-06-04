using System.Collections.Generic;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Produces("application/json")]
    public class PostsController : ControllerBase
    {
        // GET api/posts/
        [HttpGet]
        public ActionResult GetAll([FromServices] IPostService service)
        {
            var posts = service.GetAll();
            return Ok(posts);
        }

        // GET api/posts/5
        [HttpGet("{id}")]
        public ActionResult Get([FromServices] IPostService service, int id)
        {
            var post = service.GetById(id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        // POST api/posts
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/posts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/posts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}