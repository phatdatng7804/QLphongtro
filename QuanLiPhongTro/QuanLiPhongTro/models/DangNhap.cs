namespace QuanLiPhongTro.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangNhap")]
    public partial class DangNhap
    {
        [Key]
        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [StringLength(250)]
        public string MatKhau { get; set; }

        public virtual DangKi DangKi { get; set; }
    }
}
