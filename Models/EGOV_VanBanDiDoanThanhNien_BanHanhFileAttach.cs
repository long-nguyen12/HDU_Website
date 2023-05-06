namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDiDoanThanhNien_BanHanhFileAttach
    {
        public int ID { get; set; }

        public int? IDVanBanDiDoanThanhNien { get; set; }

        public int IDFile { get; set; }
    }
}
