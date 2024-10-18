
using MScoreStudent.Domain.Auditable;

namespace MScoreStudent.Domain.Entities
{
    public class Diem : AuditableEntity
    {
        public double DiemChuyenCan { get; set; }
        public double DiemKTGK { get; set; }
        public double DiemThucHanh { get; set; }
        public double DiemBaiTap { get; set; }
        public double DiemThiLan1 { get; set; }
        public double DiemThiLan2 { get; set; }
        public double DiemTongKet { get; set; }
        public virtual ICollection<MonHocHasGiangVien> MonHocHasGiangViens { get; set; }
        public virtual ICollection<SinhVienHasDiem> SinhVienHasDiems { get; set; }
    }
}
