namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDenCongDoanPhanCongXuLyLichSu
    {
        public int ID { get; set; }

        public int IDVanBanPCXL { get; set; }

        public int? IDTrangThaiCu { get; set; }

        public int? IDTrangThaiMoi { get; set; }

        public string NoiDung { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
