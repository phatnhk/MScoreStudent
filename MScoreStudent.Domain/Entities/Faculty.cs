using MScoreStudent.Domain.Auditable;

namespace MScoreStudent.Domain.Entities
{
    public class Faculty : AuditableEntity
    {
        public string Name { get; set; }
    }
}
