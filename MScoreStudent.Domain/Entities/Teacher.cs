using MScoreStudent.Domain.Auditable;
using MScoreStudent.Domain.Enums;

namespace MScoreStudent.Domain.Entities
{
    public class Teacher : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public string AcademicRank { get; set; } //HocHam
        public string AcademicDegree { get; set; } //hocvi
    }
}
