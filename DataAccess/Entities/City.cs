﻿using AppCore.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class City : RecordBase
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        public int? CountryId { get; set; }
        public Country? Country { get; set; }

        public List<Actor>? Actors { get; set; }
    }
}
