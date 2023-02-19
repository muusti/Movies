﻿using AppCore.Records.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class CountryModel : RecordBase
    {
        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(100, ErrorMessage = "{0} must be maximum {1} characters!")]
        [DisplayName("Country Name")]
        public string Name { get; set; }
    }
}
