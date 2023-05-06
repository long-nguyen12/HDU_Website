namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_CongVanDi_BanHanh
    {
        public int ID { get; set; }

        public int IDCongVanDi { get; set; }

        public int IDDonVi { get; set; }

        public int? IDNhanSuLuuTru { get; set; }

        public string GhiChu { get; set; }

        public int? IDNguoiTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? NotifyVersion { get; set; }

        public int? ViewVersion { get; set; }

        public int? IDNguoiXem { get; set; }

        public DateTime? NgayXem { get; set; }

        public int? IDTrangThaiXuLy { get; set; }
    }
}
