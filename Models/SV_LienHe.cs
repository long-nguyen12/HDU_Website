namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SV_LienHe
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string HoTen { get; set; }

        [StringLength(500)]
        public string SoDienThoai { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(1000)]
        public string DiaChi { get; set; }

        [StringLength(1000)]
        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        public byte? ContactStatus { get; set; }

        public bool? IsDaLienHe { get; set; }

        [StringLength(50)]
        public string MaSV { get; set; }

        public int? IDPhongBan { get; set; }

        public int? IDNguoiChuyenPhongBan { get; set; }

        public DateTime? NgayChuyen { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
