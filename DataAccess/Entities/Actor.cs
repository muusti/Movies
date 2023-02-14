using AppCore.Records.Bases;
using DataAccess.Enums;

namespace DataAccess.Entities
{
    public class Actor : RecordBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
    }
}
