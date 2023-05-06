namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_DuAn
    {
        public int ID { get; set; }

        [StringLength(1000)]
        public string TieuDe { get; set; }

        [StringLength(4000)]
        public string MoTa { get; set; }

        [StringLength(4000)]
        public string HinhDaiDien { get; set; }

        public bool? IsHienThi { get; set; }

        public bool? IsShowSlideHinh { get; set; }

        public bool? IsFullWidth { get; set; }

        public int? SoThuTu { get; set; }

        public string NoiDung { get; set; }

        public string NoiDungTab01 { get; set; }

        public string NoiDungTab02 { get; set; }

        public string NoiDungTab03 { get; set; }

        public string NoiDungTab04 { get; set; }

        public string NoiDungTab05 { get; set; }

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
