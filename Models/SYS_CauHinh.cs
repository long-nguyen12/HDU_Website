namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_CauHinh
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string KeyCauHinh { get; set; }

        [StringLength(200)]
        public string TenCauHinh { get; set; }

        [StringLength(1000)]
        public string MoTa { get; set; }

        public int? Loai { get; set; }

        public int? SoThuTu { get; set; }

        [StringLength(1000)]
        public string ElementsCSS { get; set; }

        public int? IDNhom { get; set; }

        [StringLength(50)]
        public string MaNhom { get; set; }
    }
}
