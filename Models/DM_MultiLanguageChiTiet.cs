namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_MultiLanguageChiTiet
    {
        public int ID { get; set; }

        public int IDKey { get; set; }

        public string ValueLang { get; set; }

        [StringLength(20)]
        public string Language { get; set; }

        [StringLength(200)]
        public string TenNgonNgu { get; set; }

        public bool? IsDelete { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? NguoiCapNhat { get; set; }
    }
}
