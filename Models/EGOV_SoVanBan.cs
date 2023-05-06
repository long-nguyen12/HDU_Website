namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_SoVanBan
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string TenSoVanBan { get; set; }

        public int? IDCoSo { get; set; }

        public int? SoThuTu { get; set; }

        public string GhiChu { get; set; }

        public DateTime? ThoiGianHieuLucTuNgay { get; set; }

        public DateTime? ThoiGianHieuLucDenNgay { get; set; }

        public int? IDDoiTuongSuDung { get; set; }

        public int? IDTrangThai { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public bool? IsPublic { get; set; }
    }
}
