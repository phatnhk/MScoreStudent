using Microsoft.EntityFrameworkCore;
using MScoreStudent.Application.Auditable.Models;

namespace MScoreStudent.Application.AuditTrailDbContext
{
    public abstract class AuditableContext : DbContext
    {
        public AuditableContext(DbContextOptions options)
        : base(options)
        {
        }

        public DbSet<Audit> AuditLogs { get; set; }
    }
}
