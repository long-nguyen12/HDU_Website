namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_Nganh
    {
        public int ID { get; set; }

        public int? IDNhomNganh { get; set; }

        [StringLength(500)]
        public string TenNhomNganh { get; set; }

        public int? IDLinhVuc { get; set; }

        [StringLength(50)]
        public string MaNganh { get; set; }

        [StringLength(500)]
        public string TenNganh { get; set; }

        [StringLength(200)]
        public string TenVietTat { get; set; }

        [StringLength(200)]
        public string TenTiengAnh { get; set; }

        public string MoTa { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? SoThuTu { get; set; }

        public bool? IsHienThi { get; set; }

        public int? ForWeb { get; set; }

        public int? IDTruong { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDChuongTrinhDaoTao { get; set; }

        [StringLength(200)]
        public string HinhDaiDien { get; set; }

        [StringLength(200)]
        public string CssClass { get; set; }

        public string NoiDungGioiThieu { get; set; }
    }
}
