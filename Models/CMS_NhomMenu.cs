namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_NhomMenu
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaNhom { get; set; }

        [Required]
        [StringLength(200)]
        public string TenNhom { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        [StringLength(100)]
        public string CssClass { get; set; }

        public bool? IsSuDung { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        [StringLength(200)]
        public string HinhDaiDien { get; set; }
    }
}
