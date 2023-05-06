namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASC_HopDong
    {
        public int ID { get; set; }

        public int? IDKhachHang { get; set; }

        [StringLength(100)]
        public string SoHopDong { get; set; }

        public DateTime? NgayHopDong { get; set; }

        [StringLength(200)]
        public string TenHopDong { get; set; }

        public int? TrangThai { get; set; }

        public decimal? GiaTriHopDong { get; set; }

        public int? ThoiGianHopDong { get; set; }

        public string GhiChu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDLoaiHD { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        public int? IDNguoiPhuTrach { get; set; }

        [StringLength(4000)]
        public string GhiChuHoSo { get; set; }

        [StringLength(4000)]
        public string GhiChuHoSoNghiemThu { get; set; }
    }
}
