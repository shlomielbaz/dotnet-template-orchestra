
using DT.Data;
using DT.Domain.Entities;
using DT.Domain.Enums;
using DT.Domain.Interfaces;
using DT.Domain.Models;
using DT.Utils;

namespace DT.Services
{
    public class UserService : IUserService
    {
        private IRepository<DataContext> _db;

        public UserService(IRepository<DataContext> db)
        {
            _db = db;
        }

        public IEnumerable<UserViewModel> Get()
        {
            return _db.GetList<User>().Select(x => new UserViewModel()
            {
                Name = x.Name,
                Email = x.Email,
                Role = x.Role.GetDescription<RoleType>(),
                Id = x.ID.ToString()
            });
        }

        public UserViewModel Get(string id)
        {
            User user = _db.Get<User>(x => x.ID.ToString().ToLower() == id.ToLower());
            
            return new UserViewModel()
            {
                Name = user.Name,
                Email = user.Email,
                Role = ((int)user.Role).ToString(),
                Id = user.ID.ToString(),
                OrganizationId = user.OrganizationId.ToString(),
            };
        }


        public void Add(AddUserViewModel model)
        {
            _db.Add<User>(new User()
            {
                Name = model.Name,
                Email = model.Email,
                Role = (RoleType)model.Role,
                OrganizationId = Guid.Parse(model.OrganizationId)
            });

            _db.Save("The save user failed");
        }

        public void Delete(string id)
        {
            User user = _db.Get<User>(x => x.ID.ToString().ToLower() == id.ToLower());

            _db.Delete<User>(user);

            _db.Save("The delete user failed");
        }

        public void Update(string id, UserViewModel model)
        {
            User user = _db.Get<User>(x => x.ID.ToString().ToLower() == id.ToLower());

            user.Name = model.Name;
            user.Email = model.Email;
            user.OrganizationId = Guid.Parse(model.OrganizationId);
            user.Role = (RoleType)int.Parse(model.Role);

            _db.Update<User>(user);

            _db.Save("The delete user failed");
        }
    }
}
