namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VBDH_VanBanLienQuan
    {
        public int ID { get; set; }

        public int? IDLoaiVBLQ { get; set; }

        public int? IDVBDH { get; set; }

        public int? IDVBLQ { get; set; }

        public int? SoThuTu { get; set; }
    }
}
