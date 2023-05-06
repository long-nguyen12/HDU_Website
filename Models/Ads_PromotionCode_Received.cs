namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ads_PromotionCode_Received
    {
        public long ID { get; set; }

        public long? IDPromotionDiary { get; set; }

        [StringLength(100)]
        public string PromotionCode { get; set; }

        [StringLength(200)]
        public string NoiDung { get; set; }

        public DateTime? NgayHieuLuc { get; set; }

        public DateTime? NgayHetHan { get; set; }
    }
}
