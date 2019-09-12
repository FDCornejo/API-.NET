using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.Services;

namespace WebApplication8.Controllers
{
    [Produces("application/json")]
    [Route("api/Posts")]
    public class PostsController : ControllerBase
    {
        private PostService _postService;
        public PostsController(PostService postService)
        {
            _postService = postService;
        }

        // GET: api/Posts
        [HttpGet]
        public IEnumerable<PostModel> Get()
        {
            return _postService.GetPosts();
        }

        // GET: api/Posts/5
        [HttpGet("{id}", Name = "Getpots")]
        public PostModel Get(int id) => _postService.SeePost(id);
        
        // POST: api/Posts
        [HttpPost]
        public void Post([FromBody]PostModel posteo)
        {
            _postService.AddPosts(posteo);


        }

        // PUT: api/Posts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]PostModel thepost) => _postService.EditPost(id, thepost);

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id) => _postService.deletePost(id);
    }
}
