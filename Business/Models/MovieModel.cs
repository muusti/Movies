using AppCore.Records.Bases;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class MovieModel : RecordBase
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        public DateTime? YearOfConstruction { get; set; }

        [Required]
        [StringLength(50)]
        public string? Category { get; set; }

    }
}
