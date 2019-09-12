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
    [Route("api/Coments")]
    public class ComentsController : ControllerBase
    {
        private ComentService _comentService;
        public ComentsController(ComentService comentService)
        {
            _comentService = comentService;
        }

        // GET: api/Coments
        [HttpGet]                       
        public IEnumerable<ComentModel> Get()
        {
            return _comentService.GetComents();
        }

        // GET: api/Coments/5
        [HttpGet("{id}", Name = "Getcoments")]
        public ComentModel Get(int id) => _comentService.SeeComent(id);
        
        // POST: api/Coments
        [HttpPost]
        public void Post([FromBody]ComentModel coment)
        {
            _comentService.AddComents(coment);
        }

        // PUT: api/Coments/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]ComentModel coment) => _comentService.EditComent(id, coment);

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id) => _comentService.DeleteComent(id);
    }
}
