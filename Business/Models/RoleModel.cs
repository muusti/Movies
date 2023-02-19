using AppCore.Records.Bases;
using System.ComponentModel;

namespace Business.Models
{
    public class RoleModel : RecordBase
    {
        [DisplayName("Role")]
        public string Name { get; set; }
    }
}
