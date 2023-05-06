namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_MenuSinhVien
    {
        public int ID { get; set; }

        public int? IDSysMenu { get; set; }

        public int? SoThuTu { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? LoaiMenu { get; set; }
    }
}
