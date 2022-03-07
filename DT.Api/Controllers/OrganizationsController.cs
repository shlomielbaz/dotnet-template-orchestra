using DT.Domain.Interfaces;
using DT.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DT.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        private IOrganizationService _service;
        public OrganizationsController(IOrganizationService service)
        {
            _service = service;
        }
        // GET: api/<OrganizationsController>
        [HttpGet]
        public IEnumerable<OrganizationViewModel> Get()
        {
            return _service.Get();
        }

        // GET api/<OrganizationsController>/5
        [HttpGet("{id}")]
        public OrganizationViewModel Get(string id)
        {
            return _service.Get(id);
        }

        // POST api/<OrganizationsController>
        [HttpPost]
        public void Post(AddOrganizationViewModel model)
        {
            _service.Add(model);
        }

        // PUT api/<OrganizationsController>/5
        [HttpPut("{id}")]
        public void Put(string id, OrganizationViewModel model)
        {
            _service.Update(id, model);
        }

        // DELETE api/<OrganizationsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _service.Delete(id);
        }
    }
}
