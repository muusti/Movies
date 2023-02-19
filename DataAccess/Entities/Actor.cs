using AppCore.Records.Bases;
using DataAccess.Enums;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Actor : RecordBase
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(100)]
        public string? Surname { get; set; }

        public Gender? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public int? CountryId { get; set; }
        public Country? Country { get; set; }

        public int? CityId { get; set; }
        public City? City { get; set; }

        public List<MovieActor>? MovieActors { get; set; }
        public List<Character>? Characters { get; set; }

    }
}
