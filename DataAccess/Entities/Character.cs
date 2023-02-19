using AppCore.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Character : RecordBase
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(100)]
        public string? SurName { get; set; }

        public int? ActorId { get; set; }
        public Actor? Actor { get; set; }

    }
}
