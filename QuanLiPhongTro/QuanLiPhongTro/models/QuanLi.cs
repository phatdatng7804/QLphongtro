using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLiPhongTro.models
{
    public partial class QuanLi : DbContext
    {
        public QuanLi()
            : base("name=QuanLiTro")
        {
        }

        public virtual DbSet<DangKi> DangKis { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DangKi>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<DangKi>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<DangKi>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<DangNhap>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<DangNhap>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<DangNhap>()
                .HasOptional(e => e.DangKi)
                .WithRequired(e => e.DangNhap);
        }
    }
}
