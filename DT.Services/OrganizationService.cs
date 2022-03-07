using DT.Data;
using DT.Domain.Entities;
using DT.Domain.Interfaces;
using DT.Domain.Models;

namespace DT.Services
{
    public class OrganizationService : IOrganizationService
    {
        private IRepository<DataContext> _db;

        public OrganizationService(IRepository<DataContext> db)
        {
            _db = db;
        }

        public void Add(AddOrganizationViewModel model)
        {
            _db.Add<Organization>(new Organization()
            {
                Name = model.Name,
            });

            _db.Save("The save organization failed");
        }

        public void Delete(string id)
        {
            Organization organization = _db.Get<Organization>(x => x.ID.ToString().ToLower() == id.ToLower());

            _db.Delete<Organization>(organization);

            _db.Save("The delete organization failed");
        }

        public IEnumerable<OrganizationViewModel> Get()
        {
            return _db.GetList<Organization>().Select(x => new OrganizationViewModel()
            {
                Name = x.Name,
                Id = x.ID.ToString()
            });
        }

        public OrganizationViewModel Get(string id)
        {
            Organization organization = _db.Get<Organization>(x => x.ID.ToString().ToLower() == id.ToLower());

            return new OrganizationViewModel()
            {
                Name = organization.Name,
                Id = organization.ID.ToString()
            };
        }

        public void Update(string id, OrganizationViewModel model)
        {
            Organization organization = _db.Get<Organization>(x => x.ID.ToString().ToLower() == id.ToLower());

            organization.Name = model.Name;

            _db.Update<Organization>(organization);

            _db.Save("The delete organization failed");
        }
    }
}
