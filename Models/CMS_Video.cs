namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_Video
    {
        public int ID { get; set; }

        [Required]
        [StringLength(300)]
        public string TieuDe { get; set; }

        [StringLength(300)]
        public string HinhDaiDien { get; set; }

        [StringLength(500)]
        public string LinkVideo { get; set; }

        [StringLength(1000)]
        public string MoTa { get; set; }

        public string NoiDung { get; set; }

        public int? SoThuTu { get; set; }

        public bool? IsHienThi { get; set; }

        public bool? IsNoiBat { get; set; }

        public int? IDLoai { get; set; }

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
