namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TSHN_DM_Khoa
    {
        public int ID { get; set; }

        public int? IDCoSo { get; set; }

        [StringLength(20)]
        public string MaPhongBan { get; set; }

        [StringLength(200)]
        public string TenPhongBan { get; set; }

        [StringLength(20)]
        public string VietTat { get; set; }

        [StringLength(20)]
        public string SoDienThoai { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string ChucVuNguoiDaiDien { get; set; }

        [StringLength(100)]
        public string NguoiDaiDien { get; set; }

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
    }
}
