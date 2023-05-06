namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDiDang_BanHanhViewed
    {
        public int ID { get; set; }

        public int? IDVanBanDiDang { get; set; }

        public int? IDNguoiDung { get; set; }

        public DateTime? NgayXem { get; set; }
    }
}
