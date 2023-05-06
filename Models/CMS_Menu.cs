namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_Menu
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string TieuDe { get; set; }

        [StringLength(500)]
        public string HinhDaiDien { get; set; }

        public int? IDThamChieu { get; set; }

        public int? IDNhom { get; set; }

        public int? Ordering { get; set; }

        public int? Level { get; set; }

        public bool IsHienThi { get; set; }

        [StringLength(50)]
        public string ClassCss { get; set; }

        public int? IDRouter { get; set; }

        public int? RouterType { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        public int? LoaiMenu { get; set; }

        public int? IDMap { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        [StringLength(2000)]
        public string MoTa { get; set; }
    }
}
