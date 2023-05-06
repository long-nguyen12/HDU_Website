namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_Website
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MaWeb { get; set; }

        [StringLength(200)]
        public string TenWeb { get; set; }

        [StringLength(200)]
        public string TenVietTat { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string SoDienThoai { get; set; }

        [StringLength(100)]
        public string SoFax { get; set; }

        public bool? IsSuDung { get; set; }

        public int? SoThuTu { get; set; }

        public int? IDGiaoDien { get; set; }

        [StringLength(200)]
        public string LogoDashBoard { get; set; }

        public int? IDPhong { get; set; }

        public int? IDLoaiWeb { get; set; }

        public bool? IsDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public int? IDThamChieu { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public bool? IsToken { get; set; }

        public bool? IsUseTruong { get; set; }

        [StringLength(10)]
        public string UniversityID { get; set; }

        [StringLength(20)]
        public string DBHRM { get; set; }

        [StringLength(10)]
        public string SystemID { get; set; }

        public bool? IsV2 { get; set; }
    }
}
