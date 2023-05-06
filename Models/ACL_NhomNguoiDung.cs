namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACL_NhomNguoiDung
    {
        public int ID { get; set; }

        public int? IDThamChieu { get; set; }

        [StringLength(100)]
        public string HoDem { get; set; }

        [Required]
        [StringLength(500)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [StringLength(200)]
        public string MatKhau { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        public string SoDiDong { get; set; }

        [StringLength(500)]
        public string DonViCongTac { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        public bool? IsRoot { get; set; }

        public bool? IsNhom { get; set; }

        public bool? IsActive { get; set; }

        public int? LoaiDoiTuong { get; set; }

        public int? IDMapDoiTuong { get; set; }

        public Guid? Token { get; set; }

        public int? IDTruong { get; set; }

        public bool? IsKhachHang { get; set; }

        public int ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDKhachHang { get; set; }

        public int? IDHinhDaiDien { get; set; }

        [StringLength(50)]
        public string MaXacThuc { get; set; }

        public DateTime? NgayTaoMaXacThuc { get; set; }

        public DateTime? NgayHetHanMaXacThuc { get; set; }

        public int? SoThuTu { get; set; }
    }
}
