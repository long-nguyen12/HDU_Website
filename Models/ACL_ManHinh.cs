namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACL_ManHinh
    {
        public int ID { get; set; }

        public int? IDThamChieu { get; set; }

        [StringLength(200)]
        public string TenManHinh { get; set; }

        [StringLength(200)]
        public string TenAction { get; set; }

        [StringLength(200)]
        public string TenController { get; set; }

        [StringLength(200)]
        public string Area { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? SoThuTu { get; set; }

        [StringLength(100)]
        public string CssClass { get; set; }

        [StringLength(50)]
        public string GroupManHinh { get; set; }

        public bool? IsSuDung { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        [StringLength(50)]
        public string CssBadge { get; set; }
    }
}
