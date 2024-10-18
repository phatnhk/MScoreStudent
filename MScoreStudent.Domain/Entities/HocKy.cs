using MScoreStudent.Domain.Auditable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScoreStudent.Domain.Entities
{
    public class HocKy : AuditableEntity
    {
        public string TenHocKy { get; set; }
        public string NamHoc { get; set; }
    }
}
