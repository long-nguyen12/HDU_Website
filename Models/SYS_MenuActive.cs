namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_MenuActive
    {
        public int ID { get; set; }

        public int? IDSysMenu { get; set; }

        [StringLength(200)]
        public string TenMenu { get; set; }

        [StringLength(100)]
        public string TenVietTat { get; set; }

        [StringLength(100)]
        public string CssClass { get; set; }

        [StringLength(200)]
        public string LienKet { get; set; }

        [StringLength(1)]
        public string HinhDaiDien { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }
    }
}
