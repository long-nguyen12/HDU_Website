namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ads_Promotion_Diary
    {
        public long ID { get; set; }

        public int? IDQuangCao { get; set; }

        public int? IDKhachHang { get; set; }

        public int? IDPhanHe { get; set; }

        public int? IDUser { get; set; }

        public bool? DaNhan { get; set; }

        public DateTime? NgayNhan { get; set; }
    }
}
