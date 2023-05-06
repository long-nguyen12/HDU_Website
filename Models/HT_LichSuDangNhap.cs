namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HT_LichSuDangNhap
    {
        public int ID { get; set; }

        public int? IDNhomNguoiDung { get; set; }

        public DateTime? NgayThaoTac { get; set; }

        public DateTime? ThoiGianDangNhap { get; set; }

        public DateTime? ThoiGianDangXuat { get; set; }

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
    }
}
