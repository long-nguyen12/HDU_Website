namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASC_DatVe
    {
        public int ID { get; set; }

        public int? PhuongTien { get; set; }

        [StringLength(200)]
        public string NoiKhoiHanh { get; set; }

        [StringLength(200)]
        public string NoiDen { get; set; }

        public decimal? SoTien { get; set; }

        public int? IDKhachHang { get; set; }

        public DateTime? BatDau { get; set; }

        public DateTime? KetThuc { get; set; }

        [StringLength(4000)]
        public string GhiChu { get; set; }

        public int? TrangThai { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
