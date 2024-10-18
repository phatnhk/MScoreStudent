using MScoreStudent.Domain.Auditable;

namespace MScoreStudent.Domain.Entities
{
    public class MonHoc : AuditableEntity
    { 
        public string TenMon { get; set; }
        public string TenBoMon { get; set; }
        public string SoTinChi { get; set; }
        public virtual ICollection<SinhVienHasMonHoc> SinhVienHasMonHocs { get; set; }
        public virtual ICollection<MonHocHasGiangVien> MonHocHasGiangViens { get; set; }
    }
}
