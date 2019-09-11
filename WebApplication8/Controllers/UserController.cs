using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.Services;
using WebApplication8.Repositories;

namespace WebApplication8.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {   //Aqui declaro un servicio
        private UserService _userService;

        public UserController(UserService userService)
        {
            //Aqui lo inicializo
            _userService = userService;
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return _userService.GetUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetUser")]
        public UserModel Get(int id) => _userService.SeeUser(id);

        // POST: api/User
        [HttpPost]
        public void Post([FromBody]UserModel user)
        {
            _userService.AddUser(user);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]UserModel theUser)
        {
            _userService.updateUser(id, theUser);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.removeUser(id);
        }
    }
}
