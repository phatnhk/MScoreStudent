using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScoreStudent.Domain.Entities
{
    public class MonHocHasGiangVien
    {
        public int MaMon { get; set; }
        public int MaGiangVien { get; set; }
        public int MaDiem { get; set; }

        // Điều hướng (navigation properties)
        public virtual MonHoc MonHoc { get; set; }
        public virtual GiangVien GiangVien { get; set; }
        public virtual Diem Diem { get; set; }
    }
}
