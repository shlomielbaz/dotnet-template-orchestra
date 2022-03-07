using DT.Domain.Models;

namespace DT.Domain.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserViewModel> Get();
        UserViewModel Get(string id);
        void Add(AddUserViewModel model);
        void Update(string id, UserViewModel model);
        void Delete(string id);
    }
}
