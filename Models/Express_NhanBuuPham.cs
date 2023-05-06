namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Express_NhanBuuPham
    {
        public int ID { get; set; }

        [StringLength(2500)]
        public string TenHang { get; set; }

        public int? IDDonViGui { get; set; }

        [StringLength(500)]
        public string DonViGui { get; set; }

        public bool? IsDonViGuiNgoaiHeThong { get; set; }

        public DateTime? NgayGui { get; set; }

        public int? IDNguoiGui { get; set; }

        [StringLength(500)]
        public string NguoiGui { get; set; }

        public int? IDDonViNhan { get; set; }

        [StringLength(500)]
        public string DonViNhan { get; set; }

        public int? IDNguoiNhan { get; set; }

        [StringLength(500)]
        public string NguoiNhan { get; set; }

        public bool? IsNhanNgoaiHeThong { get; set; }

        public int? TrangThai { get; set; }

        public int? ForWeb { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? NguoiTao { get; set; }

        public int? IDDonViNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public DateTime? NgayNhan { get; set; }

        [StringLength(50)]
        public string SoDienThoaiNguoiGui { get; set; }

        [StringLength(50)]
        public string SoDienThoaiNguoiNhan { get; set; }

        public DateTime? NgayTiepNhan { get; set; }
    }
}
