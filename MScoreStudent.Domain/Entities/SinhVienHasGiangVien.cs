namespace MScoreStudent.Domain.Entities
{
    public class SinhVienHasGiangVien
    {
        public int MaSV { get; set; }
        public int MaGiangVien { get; set; }

        // Điều hướng (navigation properties)
        public virtual SinhVien SinhVien { get; set; }
        public virtual GiangVien GiangVien { get; set; }
    }
}
