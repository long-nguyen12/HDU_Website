namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_YeuCauCongViec_PhieuYeuCau
    {
        public int ID { get; set; }

        public int? IDNguoiDeNghi { get; set; }

        [StringLength(50)]
        public string MaPhieuYeuCau { get; set; }

        [StringLength(2000)]
        public string TenPhieuYeuCau { get; set; }

        public int? IDDonViCoYeuCau { get; set; }

        public int? IDTrangThaiYeuCau { get; set; }

        [StringLength(200)]
        public string SoVaoSo { get; set; }

        public DateTime? NgayCapSoVaoSo { get; set; }

        public decimal? SoNgayGiaiQuyet { get; set; }

        public int? IDTrangThaiDanhGia { get; set; }

        public string LyDoKhongDungHan { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public bool? IsCoVanBanGiay { get; set; }

        public string GhiChu { get; set; }
    }
}
