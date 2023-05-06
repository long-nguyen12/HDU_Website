namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_SlideShow
    {
        public int ID { get; set; }

        [Required]
        [StringLength(500)]
        public string TieuDe { get; set; }

        [StringLength(1000)]
        public string MoTa { get; set; }

        [StringLength(300)]
        public string HinhDaiDien { get; set; }

        [StringLength(300)]
        public string LienKet { get; set; }

        public int? SoThuTu { get; set; }

        public int? SoLuongXem { get; set; }

        public int? IDLoai { get; set; }

        public bool? IsHienThi { get; set; }

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
