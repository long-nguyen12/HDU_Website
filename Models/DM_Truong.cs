namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_Truong
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MaTruong { get; set; }

        [StringLength(200)]
        public string TenTruong { get; set; }

        [StringLength(200)]
        public string TenVietTat { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string SoDienThoai { get; set; }

        [StringLength(100)]
        public string SoFax { get; set; }

        public int? SoThuTu { get; set; }

        public bool? IsHienThi { get; set; }

        public int? IDPhongGiaoDuc { get; set; }

        public int? IDLoaiTruong { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? ForWeb { get; set; }

        public int? IDSoGiaoDuc { get; set; }

        [StringLength(500)]
        public string Website { get; set; }

        public int? IDDiaChiTinhThanhPho { get; set; }

        public int? IDDiaChiHuyenQuan { get; set; }

        public int? IDDiaChiXaPhuong { get; set; }

        [StringLength(300)]
        public string DiaChiSoNha { get; set; }

        [StringLength(200)]
        public string HinhDaiDien { get; set; }

        public string MoTa { get; set; }

        [StringLength(200)]
        public string HinhLogo { get; set; }
    }
}
