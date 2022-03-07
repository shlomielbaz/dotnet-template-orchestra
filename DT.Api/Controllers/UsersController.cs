using DT.Domain.Interfaces;
using DT.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DT.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _service;
        public UsersController(IUserService service)
        {
            _service = service;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<UserViewModel> Get()
        {
            return _service.Get();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public UserViewModel Get(string id)
        {
            return _service.Get(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post(AddUserViewModel model)
        {
            _service.Add(model);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(string id, UserViewModel model)
        {
            _service.Update(id, model);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _service.Delete(id);
        }
    }
}
