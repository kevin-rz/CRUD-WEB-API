using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlogWebAPI.Services;
using BlogWebAPI.Controllers;
using BlogWebAPI.Models;
using Microsoft.Extensions.Logging;

namespace BlogWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private PostService _postService;
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger, PostService postService)
        {
            _postService = postService;
            _logger = logger;
        }

        // GET: api/User
        [HttpGet]
        public List<PostModel> Get()
        {
            return _postService.GetPosts();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetPost")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public string Post([FromBody] PostModel post)
        {
            return _postService.AddPost(post);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] PostModel post)
        {
            return _postService.EditPost(id, post);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _postService.DeletePost(id);
        }
    }
}