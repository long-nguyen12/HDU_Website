namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDiDoanThanhNien_BanHanh
    {
        public int ID { get; set; }

        public int IDVanBanDiDoanThanhNien { get; set; }

        public int IDDonVi { get; set; }

        public int? IDNhanSuLuuTru { get; set; }

        public string GhiChu { get; set; }

        public int? IDNguoiTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }
    }
}
