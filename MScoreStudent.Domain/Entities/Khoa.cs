using MScoreStudent.Domain.Auditable;

namespace MScoreStudent.Domain.Entities
{
    public class Khoa : AuditableEntity
    {
        public string TenKhoa { get; set; }
        public virtual ICollection<Lop> Lops { get; set; }
        public virtual ICollection<GiangVien> GiangViens { get; set; }
    }
}
