using MScoreStudent.Domain.Auditable;

namespace MScoreStudent.Domain.Entities
{
    public class Student : AuditableEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Hometown { get; set; }
    }
}
