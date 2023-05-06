namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ELN_BaiGiangComment
    {
        public int ID { get; set; }

        public int? IDThamChieu { get; set; }

        public int? IDBaiGiang { get; set; }

        public int? IDThanhVien { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(200)]
        public string HoTen { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(200)]
        public string DienThoai { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(500)]
        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        public int? SoLuotThich { get; set; }

        public int? SoLuotKhongThich { get; set; }

        public bool? IsDaXem { get; set; }

        public bool? IsHienThi { get; set; }

        public bool? IsDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }
    }
}
