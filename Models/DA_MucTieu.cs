namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DA_MucTieu
    {
        public int ID { get; set; }

        public int? Type { get; set; }

        public int? MonthNumber { get; set; }

        public int? YearNumber { get; set; }

        public int? WeekNumber { get; set; }

        public int? LoaiMucTieu { get; set; }

        public int? NhomMucTieu { get; set; }

        [StringLength(300)]
        public string MucTieu { get; set; }

        [StringLength(4000)]
        public string PPTienHanh { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public DateTime? HanKetThuc { get; set; }

        public int? DoUuTien { get; set; }

        public int? TrangThai { get; set; }

        public int? PhanTramHoanThanh { get; set; }

        public int? IDPhongBan { get; set; }

        public int? IDNguoiThucHien { get; set; }

        public int ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
