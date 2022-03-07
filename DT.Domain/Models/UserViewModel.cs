
using DT.Domain.Interfaces;

namespace DT.Domain.Models
{
    public class UserViewModel : IViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string OrganizationId { get; set; }
        public string Id { get; set; }
    }
}
