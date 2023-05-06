namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_BinhChonAnh
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaBC { get; set; }

        [StringLength(200)]
        public string Ten { get; set; }

        [StringLength(500)]
        public string HinhDaiDien { get; set; }

        public string MoTa { get; set; }

        public string NoiDung { get; set; }

        public int? SoLuotXem { get; set; }

        public int? SoLuotBinhChon { get; set; }

        public bool? IsHienThi { get; set; }

        public int? NguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? ForWeb { get; set; }
    }
}
