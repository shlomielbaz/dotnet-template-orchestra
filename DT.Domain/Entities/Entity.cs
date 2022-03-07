using System.ComponentModel.DataAnnotations;

namespace DT.Domain.Entities
{
    public class Entity
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid ID { get; set; }
    }
}
