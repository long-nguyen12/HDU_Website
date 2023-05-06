namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_SoDoToChucChiTiet
    {
        public int ID { get; set; }

        public int? IDSoDoToChuc { get; set; }

        [StringLength(200)]
        public string TieuDe { get; set; }

        [StringLength(500)]
        public string HoTen { get; set; }

        public string HinhDaiDien { get; set; }

        [StringLength(500)]
        public string ChucVu { get; set; }

        [StringLength(500)]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        public string DiDong { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        public string GhiChu { get; set; }

        public int? TrangThai { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? SoThuTu { get; set; }
    }
}
