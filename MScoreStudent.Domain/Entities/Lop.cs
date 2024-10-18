using MScoreStudent.Domain.Auditable;

namespace MScoreStudent.Domain.Entities
{
    public class Lop : AuditableEntity
    {
        public string TenLop { get; set; }
        
        // Khóa ngoại
        public int MaKhoa { get; set; }

        // Điều hướng (navigation property)
        public virtual Khoa Khoa { get; set; }
    }
}
