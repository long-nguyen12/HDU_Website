namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_DangKyVang
    {
        public int ID { get; set; }

        public int IDNguoiDangKy { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public DateTime? GioBatDau { get; set; }

        public DateTime? GioKetThuc { get; set; }

        public bool CaNgay { get; set; }

        public double? SoGio { get; set; }

        public string LyDo { get; set; }

        public bool? DaDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public string LyDoKhongDuyet { get; set; }

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
