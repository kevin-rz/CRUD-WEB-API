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
    public class UserController : ControllerBase
    {
        private UserService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, UserService userService) {
            _userService = userService;
            _logger = logger;
        }
        
        /*
        public UserController(ILogger<UserController> logger, UserService userService)
        {
            _userService = userService;
            _logger = logger;
        }*/

        // GET: api/User
        [HttpGet]
        public List<UserModel> Get()
        {
            return _userService.GetUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetUser")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public string Post([FromBody] UserModel user)
        {
            return _userService.AddUser(user);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] UserModel user)
        {
            return _userService.EditUser(id, user);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _userService.DeleteUser(id);
        }
    }
}
