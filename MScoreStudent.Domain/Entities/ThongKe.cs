using MScoreStudent.Domain.Auditable;

namespace MScoreStudent.Domain.Entities
{
    public class ThongKe : AuditableEntity
    {
        public double DiemTrungBinh { get; set; }
        public double DiemRenLuyen { get; set; }
        //(navigation property)
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
