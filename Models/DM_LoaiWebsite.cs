namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LoaiWebsite
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string TenLoaiWeb { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        [StringLength(100)]
        public string CssClass { get; set; }

        public int? SoThuTu { get; set; }

        public bool? IsSuDung { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
