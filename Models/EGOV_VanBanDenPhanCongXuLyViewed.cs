namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDenPhanCongXuLyViewed
    {
        public int ID { get; set; }

        public int? IDVanBanDenPhanCong { get; set; }

        public int? IDNhomNguoiDung { get; set; }

        public int? LoaiDoiTuong { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
