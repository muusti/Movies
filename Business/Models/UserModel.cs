using AppCore.Records.Bases;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Business.Models
{
    public class UserModel : RecordBase
    {
        [Required(ErrorMessage = "{0} is required!")]
        [MinLength(3, ErrorMessage = "{0} must be minimum {1} characters!")]
        [MaxLength(15, ErrorMessage = "{0} must be maximum {1} characters!")]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [MinLength(3, ErrorMessage = "{0} must be minimum {1} characters!")]
        [MaxLength(10, ErrorMessage = "{0} must be maximum {1} characters!")]
        public string Password { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }

        [DisplayName("Role")]
        public int RoleId { get; set; }

        [DisplayName("Country")]
        [Required(ErrorMessage = "{0} is required!")]
        public int? CountryId { get; set; }



        [DisplayName("City")]
        [Required(ErrorMessage = "{0} is required!")]
        public int? CityId { get; set; }



        public RoleModel Role { get; set; }
    }
}
