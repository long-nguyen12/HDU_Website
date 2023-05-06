namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Menu
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string TenMenu { get; set; }

        [StringLength(100)]
        public string GroupMenu { get; set; }

        [StringLength(100)]
        public string TenVietTat { get; set; }

        [StringLength(200)]
        public string TenController { get; set; }

        [StringLength(100)]
        public string TenAction { get; set; }

        [StringLength(100)]
        public string CssClass { get; set; }

        [StringLength(200)]
        public string LienKet { get; set; }

        public int? SoThuTu { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? ForWeb { get; set; }

        [StringLength(200)]
        public string HinhDaiDien { get; set; }
    }
}
