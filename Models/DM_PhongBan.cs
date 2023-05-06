namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_PhongBan
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaPhongBan { get; set; }

        [StringLength(200)]
        public string TenPhongBan { get; set; }

        [StringLength(200)]
        public string VietTat { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(100)]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? SoThuTu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDDonVi { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public bool? IsDefault { get; set; }
    }
}
