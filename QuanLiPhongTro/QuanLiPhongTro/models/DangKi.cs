namespace QuanLiPhongTro.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangKi")]
    public partial class DangKi
    {
        [Key]
        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [StringLength(250)]
        public string MatKhau { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public virtual DangNhap DangNhap { get; set; }
    }
}
