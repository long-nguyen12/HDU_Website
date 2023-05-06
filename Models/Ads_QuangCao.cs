namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ads_QuangCao
    {
        public int ID { get; set; }

        public int? IDDonViQC { get; set; }

        [StringLength(300)]
        public string HinhQuangCao { get; set; }

        [StringLength(4000)]
        public string TomTat { get; set; }

        public string NoiDung { get; set; }

        [StringLength(300)]
        public string LienKet { get; set; }

        [StringLength(20)]
        public string Target { get; set; }

        [StringLength(20)]
        public string Rel { get; set; }

        public int? IDViTri { get; set; }

        public int? IDPhanHe { get; set; }

        public decimal? GiaTienQuangCao { get; set; }

        public DateTime? TuNgayDatQuangCao { get; set; }

        public DateTime? DenNgayDatQuangCao { get; set; }

        public bool? GioiTinh { get; set; }

        public int? MucDoHienThi { get; set; }

        public bool? IsHienThi { get; set; }

        public bool? IsUuTien { get; set; }

        public int? SoThuTu { get; set; }

        [StringLength(100)]
        public string UuDai { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? SoLanClickSeAnQuangCao { get; set; }

        public bool? HasPromotionCode { get; set; }

        public byte? MaxPromotionCodeDuocNhan { get; set; }
    }
}
