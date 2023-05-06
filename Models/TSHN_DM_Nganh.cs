namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TSHN_DM_Nganh
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string MaNganh { get; set; }

        [StringLength(100)]
        public string TenNganh { get; set; }

        public int IDKhoa { get; set; }

        public int? IDKhoiNganh { get; set; }

        [StringLength(100)]
        public string TenVietTat { get; set; }

        [StringLength(100)]
        public string TenTiengAnh { get; set; }

        [StringLength(10)]
        public string MaTuyenSinh { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public int? STT { get; set; }

        public bool? IsHienThi { get; set; }

        public int? ForWeb { get; set; }

        public int? IDTruong { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public string MoTa { get; set; }

        [StringLength(200)]
        public string HinhDaiDien { get; set; }

        public int? ChiTieuTuyenSinh { get; set; }

        public decimal? HocPhiThamKhaoTu { get; set; }

        public decimal? HocPhiThamKhaoDen { get; set; }
    }
}
