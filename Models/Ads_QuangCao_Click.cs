namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ads_QuangCao_Click
    {
        public int ID { get; set; }

        public int? IDQuangCao { get; set; }

        public int? IDKhachHang { get; set; }

        public int? IDPhanHe { get; set; }

        public int? IDUser { get; set; }

        public int? Click { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(100)]
        public string ScriptKey { get; set; }

        [StringLength(200)]
        public string LocCity { get; set; }

        [StringLength(200)]
        public string LocRegion { get; set; }

        [StringLength(200)]
        public string LocCountry { get; set; }

        [StringLength(200)]
        public string LocTimezone { get; set; }

        [StringLength(200)]
        public string LocIP { get; set; }

        [StringLength(200)]
        public string Loc { get; set; }
    }
}
