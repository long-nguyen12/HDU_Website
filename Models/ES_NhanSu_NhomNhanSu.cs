namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ES_NhanSu_NhomNhanSu
    {
        public int ID { get; set; }

        public int IDNhom { get; set; }

        public int IDNhanSu { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(200)]
        public string ChucDanh { get; set; }

        public int? SoThuTu { get; set; }

        [StringLength(50)]
        public string CssNhanSu { get; set; }
    }
}
