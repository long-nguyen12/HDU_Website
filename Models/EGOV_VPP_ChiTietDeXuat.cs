namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VPP_ChiTietDeXuat
    {
        public int ID { get; set; }

        public int? IDDeXuat { get; set; }

        public int? IDVPP { get; set; }

        public int? IDDVT { get; set; }

        public int? SoLuongDeXuat { get; set; }

        public int? SoLuongDuyet { get; set; }

        [StringLength(200)]
        public string MucDichSuDung { get; set; }

        public int? SoLuongGiao { get; set; }

        public decimal? DonGia { get; set; }

        public decimal? ThanhTien { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }
    }
}
