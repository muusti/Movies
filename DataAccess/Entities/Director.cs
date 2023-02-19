using AppCore.Records.Bases;
using DataAccess.Enums;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccess.Entities
{
    public class Director : RecordBase
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(100)]
        public string? Surname { get; set; }
        public Gender? Gender { get; set; }
        public DateTime? DateOfbirth { get; set; }

        public int? MovieId { get; set; }
        public List<Movie>? Movies { get; set;}
    }
}
