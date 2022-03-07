
using DT.Domain.Interfaces;

namespace DT.Domain.Models
{
    public class AddUserViewModel : IViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
        public string OrganizationId { get; set; }
    }
}
