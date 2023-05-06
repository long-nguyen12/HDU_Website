namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_LoaiVanBanDoanThanhNien
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaLoaiVanBan { get; set; }

        [StringLength(200)]
        public string TenLoaiVanBan { get; set; }

        [StringLength(200)]
        public string NhomVanBan { get; set; }

        public int? SoCongVanDi { get; set; }

        public int? SoCongVanLuuHanh { get; set; }

        [StringLength(20)]
        public string PreFix { get; set; }

        [StringLength(20)]
        public string SufFix { get; set; }

        [StringLength(10)]
        public string SoVanBanDen { get; set; }

        [StringLength(10)]
        public string SoVanBanDi { get; set; }

        public bool? IsCapSoRieng { get; set; }

        public bool? IsQuyTrinhQuyDinh { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
