using DT.Domain.Models;

namespace DT.Domain.Interfaces
{
    public interface IOrganizationService
    {
        IEnumerable<OrganizationViewModel> Get();
        OrganizationViewModel Get(string id);
        void Add(AddOrganizationViewModel model);
        void Update(string id, OrganizationViewModel model);
        void Delete(string id);
    }
}
