﻿using AppCore.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class User : RecordBase 
    {
        [Required]
        [StringLength(20)]
        public string? UserName { get; set; }

        [Required]
        [StringLength(20)]
        public string? Password { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public int? RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
