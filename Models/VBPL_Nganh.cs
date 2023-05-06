namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VBPL_Nganh
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaNganh { get; set; }

        [StringLength(300)]
        public string TenNganh { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? SoThuTu { get; set; }

        public bool? IsSuDung { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        [Required]
        [StringLength(300)]
        public string Alias { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(500)]
        public string MetaKey { get; set; }

        [StringLength(500)]
        public string MetaDesc { get; set; }
    }
}
