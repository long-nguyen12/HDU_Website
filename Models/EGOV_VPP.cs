namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VPP
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaVPP { get; set; }

        [StringLength(200)]
        public string TenVPP { get; set; }

        public int? IDPhanLoai { get; set; }

        public decimal? DonGia { get; set; }

        public int? IDDVT { get; set; }

        [StringLength(200)]
        public string XuatXu { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
