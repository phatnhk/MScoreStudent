using Microsoft.EntityFrameworkCore;
using MScoreStudent.Application.AuditTrailDbContext;
using MScoreStudent.Domain.Entities;

namespace MScoreStudent.Infrastructure.DbContexts
{
    public class ApplicationDbContext : AuditableContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Diem> Diems { get; set; }
        public DbSet<GiangVien> GiangViens { get; set; }
        public DbSet<HocKy> HocKys { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<ThongKe> ThongKes { get; set; }
        public DbSet<SinhVienHasDiem> SinhVienHasDiems { get; set; }
        public DbSet<SinhVienHasMonHoc> SinhVienHasMonHocs { get; set; }
        public DbSet<SinhVienHasGiangVien> SinhVienHasGiangViens { get; set; }
        public DbSet<MonHocHasGiangVien> MonHocHasGiangViens { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
