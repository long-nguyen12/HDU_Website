namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDen_Ver2_PhanCongXuLy
    {
        public int ID { get; set; }

        public int? IDVanBanDen { get; set; }

        public int? IDThamChieu { get; set; }

        public int? IDNguoiChiDao { get; set; }

        public DateTime? NgayChiDao { get; set; }

        public string NoiDungChiDao { get; set; }

        public int? IDNguoiNhan { get; set; }

        public int? LoaiDoiTuong { get; set; }

        public DateTime? NgayXemChiDao { get; set; }

        public bool? IsHoanThanh { get; set; }
    }
}
