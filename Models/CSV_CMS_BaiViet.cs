namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CSV_CMS_BaiViet
    {
        public int ID { get; set; }

        public int? IDDanhMuc { get; set; }

        [StringLength(500)]
        public string TieuDe { get; set; }

        [StringLength(2000)]
        public string MoTa { get; set; }

        public string NoiDung { get; set; }

        [StringLength(200)]
        public string HinhDaiDien { get; set; }

        public bool? IsBinhLuan { get; set; }

        public int? SoThuTu { get; set; }

        public bool? IsHienThi { get; set; }

        public bool? IsKiemDuyet { get; set; }

        public int? IDNguoiKiemDuyet { get; set; }

        public DateTime? NgayKiemDuyet { get; set; }

        [StringLength(200)]
        public string CssClass { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public bool? IsDangBai { get; set; }

        public int? IDNguoiDangBai { get; set; }

        public int? SoLuotXem { get; set; }
    }
}
