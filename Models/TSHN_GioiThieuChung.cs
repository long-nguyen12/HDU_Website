namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TSHN_GioiThieuChung
    {
        public int ID { get; set; }

        public int? IDTruong { get; set; }

        public int? IDDiaChiTinhThanhPho { get; set; }

        public int? IDDiaChiHuyenQuan { get; set; }

        public int? IDDiaChiXaPhuong { get; set; }

        public int? ChiTieuTuyenSinh { get; set; }

        public decimal? HocPhiThamKhaoTu { get; set; }

        public decimal? HocPhiThamKhaoDen { get; set; }

        public DateTime? NgayNhapHocDuKien { get; set; }

        [StringLength(500)]
        public string Website { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        [StringLength(200)]
        public string HinhDaiDien { get; set; }

        public string MoTa { get; set; }
    }
}
