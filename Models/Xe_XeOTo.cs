namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Xe_XeOTo
    {
        public int ID { get; set; }

        public int? IDDonVi { get; set; }

        public int? IDLoaiXe { get; set; }

        public int? IDTaiXe { get; set; }

        [StringLength(100)]
        public string SoXe { get; set; }

        [StringLength(100)]
        public string HieuXe { get; set; }

        [StringLength(300)]
        public string HinhDaiDien { get; set; }

        public int? SoChoNgoi { get; set; }

        public decimal? DinhMuc { get; set; }

        public int? DinhKyThayDau { get; set; }

        public int? NhienLieu { get; set; }

        [StringLength(200)]
        public string NguoiQuanLy { get; set; }

        [StringLength(500)]
        public string TinhTrang { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public bool? IsDangKyGoc { get; set; }

        public bool? IsDangKyPhoto { get; set; }

        public bool? IsSuDung { get; set; }

        public int? SoThuTu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
