using MScoreStudent.Domain.Auditable;

namespace MScoreStudent.Domain.Entities
{
    public class ClassRoom : AuditableEntity
    { 
        public string Name { get; set; }
    }
}
