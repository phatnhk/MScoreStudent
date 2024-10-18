using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScoreStudent.Domain.Entities
{
    public class SinhVienHasMonHoc
    {
        public int MaSV { get; set; }
        public int MaMon { get; set; }

        // Điều hướng (navigation properties)
        public virtual SinhVien SinhVien { get; set; }
        public virtual MonHoc MonHoc { get; set; }
    }
}
