using AppCore.Records.Bases;
using DataAccess.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class DirectorModel : RecordBase
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(100)]
        public string? Surname { get; set; }
        public Gender? Gender { get; set; }

        [DisplayName("Date Of Birth")]
        public DateTime? DateOfbirth { get; set; }
    }
}
