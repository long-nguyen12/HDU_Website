namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_VanBanDen_SetTimKiem
    {
        public int ID { get; set; }

        public int? IDCauHinh { get; set; }

        [StringLength(200)]
        public string Key { get; set; }

        public int? Colxs { get; set; }

        public int? Colsm { get; set; }

        public int? Colmd { get; set; }

        public int? Collg { get; set; }

        public int? SoThuTu { get; set; }

        public bool? IsHienThi { get; set; }
    }
}
