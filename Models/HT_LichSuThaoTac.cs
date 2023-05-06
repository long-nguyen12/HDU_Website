namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HT_LichSuThaoTac
    {
        public int ID { get; set; }

        public int? IDNhomNguoiDung { get; set; }

        [StringLength(100)]
        public string HoDemNguoiDung { get; set; }

        [StringLength(500)]
        public string TenNguoiDung { get; set; }

        [StringLength(50)]
        public string TenDangNhap { get; set; }

        public int? IDNhanSu { get; set; }

        [StringLength(50)]
        public string MaNhanSu { get; set; }

        [StringLength(100)]
        public string HoDemNhanSu { get; set; }

        [StringLength(100)]
        public string TenNhanSu { get; set; }

        public DateTime? NgaySinh { get; set; }

        public int? LoaiThaoTac { get; set; }

        [StringLength(200)]
        public string TenLoaiThaoTac { get; set; }

        public DateTime? NgayGioThaoTac { get; set; }

        [StringLength(200)]
        public string FullController { get; set; }

        [StringLength(200)]
        public string TenController { get; set; }

        [StringLength(200)]
        public string TenAction { get; set; }

        public bool? IsSuccess { get; set; }

        [StringLength(200)]
        public string LocCity { get; set; }

        [StringLength(200)]
        public string LocRegion { get; set; }

        [StringLength(200)]
        public string LocCountry { get; set; }

        [StringLength(200)]
        public string LocTimezone { get; set; }

        [StringLength(200)]
        public string LocIP { get; set; }

        [StringLength(200)]
        public string Loc { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(200)]
        public string Browser { get; set; }

        public int? ForWeb { get; set; }

        [StringLength(20)]
        public string DBHRM { get; set; }
    }
}
