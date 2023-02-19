﻿using AppCore.Records.Bases;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Role :  RecordBase
    {
        [Required]
        [StringLength(20)]
        public string? Name { get; set; }

        public List<User> Users { get; set; }
    }
}
