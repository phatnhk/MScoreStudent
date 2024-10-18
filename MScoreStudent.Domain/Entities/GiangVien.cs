using MScoreStudent.Domain.Auditable;
using MScoreStudent.Domain.Enums;

namespace MScoreStudent.Domain.Entities
{
    public class GiangVien : AuditableEntity
    {
        public string Ten { get; set; }
        public string HoTenDem { get; set; }
        public DateTime NgaySinh { get; set; }
        public Gender GioiTinh { get; set; }
        public string HocHam { get; set; }
        public string HocVi { get; set; }
        // Khóa ngoại
        public int MaKhoa { get; set; }

        // Điều hướng (navigation property)
        public virtual Khoa Khoa { get; set; }
        public virtual ICollection<MonHocHasGiangVien> MonHocHasGiangViens { get; set; }
        public virtual ICollection<SinhVienHasGiangVien> SinhVienHasGiangViens { get; set; }
    }
}
