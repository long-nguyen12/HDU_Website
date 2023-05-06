namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DA_MucTieu_Nhom
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string TenNhomMucTieu { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? SoThuTu { get; set; }

        [StringLength(10)]
        public string MaMau { get; set; }

        public bool? IsDefault { get; set; }

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
