namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACL_TaiKhoan
    {
        public int ID { get; set; }

        public int? IDThamChieu { get; set; }

        [StringLength(250)]
        public string HoTen { get; set; }

        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [StringLength(200)]
        public string MatKhau { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string SoDienThoai { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        public int? IDCSGDNN { get; set; }

        public int ForWeb { get; set; }

        public bool? IsRoot { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }
    }
}
