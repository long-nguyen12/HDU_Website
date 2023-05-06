namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDi_SendMailHistory
    {
        public int ID { get; set; }

        public int IDVanBanDi { get; set; }

        public int? IDMailContent { get; set; }

        [StringLength(200)]
        public string EmailNhan { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public bool? IsDaGui { get; set; }
    }
}
