using AppCore.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Movie : RecordBase
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        public DateTime? YearOfConstruction { get; set; }

        [Required]
        [StringLength(50)]
        public string? Category { get; set; }

        public Director? Director { get; set; }
        public int? DirectorId { get; set; }
        
        public List<MovieActor>? MovieActors { get; set; }
        
    }
}
