namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_SanPham
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string TieuDe { get; set; }

        [StringLength(1000)]
        public string MoTa { get; set; }

        public string NoiDung { get; set; }

        [StringLength(4000)]
        public string HinhSanPham { get; set; }

        public decimal? GiaBan { get; set; }

        public decimal? GiaSoSanh { get; set; }

        public decimal? KhoiLuong { get; set; }

        public bool? IsVAT { get; set; }

        public bool? IsVanChuyen { get; set; }

        public bool? IsHienThi { get; set; }

        public int? SoThuTu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDDanhMuc { get; set; }

        [StringLength(4000)]
        public string HinhSanPham1 { get; set; }
    }
}
