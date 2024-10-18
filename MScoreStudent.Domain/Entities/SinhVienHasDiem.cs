using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScoreStudent.Domain.Entities
{
    public class SinhVienHasDiem
    {
        public int MaSV { get; set; }
        public int MaDiem { get; set; }

        // Điều hướng (navigation properties)
        public virtual SinhVien SinhVien { get; set; }
        public virtual Diem Diem { get; set; }
    }
}
