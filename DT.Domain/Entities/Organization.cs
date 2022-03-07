using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DT.Domain.Entities
{
    [Table("organizations")]
    public class Organization : Entity
    {
        [Column("name")]
        [Required]
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
