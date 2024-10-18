using MScoreStudent.Domain.Auditable;

namespace MScoreStudent.Domain.Entities
{
    public class SinhVien : AuditableEntity
    {
        public string Ten { get; set; }
        public string HoTenDem { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }

        public int MaThongKe { get; set; }
        public int MaLop { get; set; }
        public virtual ThongKe ThongKe { get; set; }
        public virtual ICollection<SinhVienHasMonHoc> SinhVienHasMonHocs { get; set; }
        public virtual ICollection<SinhVienHasDiem> SinhVienHasDiems { get; set; }
        public virtual ICollection<SinhVienHasGiangVien> SinhVienHasGiangViens { get; set; }
    }
}
