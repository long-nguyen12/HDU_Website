namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ELN_NhomBaiGiang
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string TenNhom { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public bool? IsSuDung { get; set; }

        public int? SoThuTu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        [StringLength(300)]
        public string SEO_URL { get; set; }

        [StringLength(200)]
        public string SEO_TITLE { get; set; }

        [StringLength(500)]
        public string SEO_MetaKey { get; set; }

        [StringLength(500)]
        public string SEO_MetaDesc { get; set; }
    }
}
