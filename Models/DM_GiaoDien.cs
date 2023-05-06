namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_GiaoDien
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaTheme { get; set; }

        [StringLength(200)]
        public string TenTheme { get; set; }

        public string HinhDaiDien { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public string NoiDung { get; set; }

        public int? SoThuTu { get; set; }

        public int? IDLoaiWeb { get; set; }

        [StringLength(100)]
        public string LinkDemo { get; set; }

        public bool? IsSuDung { get; set; }

        public bool? IsHienThi { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
