namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_TrinhKy
    {
        public int ID { get; set; }

        public int? IDDonViDeNghi { get; set; }

        public int? IDNguoiDeNghi { get; set; }

        public int? IDTrangThai { get; set; }

        [StringLength(50)]
        public string MaYeuCau { get; set; }

        [StringLength(2000)]
        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        [StringLength(200)]
        public string SoVaoSo { get; set; }

        public DateTime? NgayCapSoVaoSo { get; set; }

        public int? IDNguoiCapSo { get; set; }

        public decimal? SoNgayGiaiQuyet { get; set; }

        public int? IDTrangThaiDanhGia { get; set; }

        public string NoiDungDanhGia { get; set; }

        public string GhiChu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDNguoiDanhGia { get; set; }

        public DateTime? NgayDanhGia { get; set; }
    }
}
