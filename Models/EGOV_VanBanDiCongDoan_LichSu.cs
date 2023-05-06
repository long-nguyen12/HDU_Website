namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDiCongDoan_LichSu
    {
        public int ID { get; set; }

        public int IDVanBanDiCongDoan { get; set; }

        public int? IDTrangThaiCu { get; set; }

        public int? IDTrangThaiMoi { get; set; }

        public string GhiChu { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
