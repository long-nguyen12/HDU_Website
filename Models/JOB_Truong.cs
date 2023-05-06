namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOB_Truong
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MaTruong { get; set; }

        [StringLength(500)]
        public string TenTruong { get; set; }

        [StringLength(500)]
        public string TenTiengAnh { get; set; }

        [StringLength(200)]
        public string HinhLogo { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string SoFax { get; set; }

        [StringLength(300)]
        public string Website { get; set; }

        public string GioiThieu { get; set; }

        public int? SoThuTu { get; set; }

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
