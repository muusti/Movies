using AppCore.Records.Bases;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccess.Entities
{
    public class Director : RecordBase
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfbirth { get; set; }

    }
}
