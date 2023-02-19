using AppCore.Records.Bases;
using DataAccess.Entities;
using DataAccess.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class ActorModel : RecordBase
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(100)]
        public string? Surname { get; set; }

        public Gender? Gender { get; set; }

        [DisplayName("Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

        public int? CountryId { get; set; }

        public int? CityId { get; set; }

    }
}
