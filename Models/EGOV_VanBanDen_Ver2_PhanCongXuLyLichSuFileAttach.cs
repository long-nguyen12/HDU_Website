namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDen_Ver2_PhanCongXuLyLichSuFileAttach
    {
        public int ID { get; set; }

        public int IDPhanCongXuLyLichSu { get; set; }

        public int? IDFile { get; set; }

        public int? Loai { get; set; }

        public int? IDVanBanDen { get; set; }
    }
}
