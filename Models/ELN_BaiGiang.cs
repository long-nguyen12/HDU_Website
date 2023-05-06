namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ELN_BaiGiang
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string TenBaiGiang { get; set; }

        public string MoTa { get; set; }

        public string NoiDung { get; set; }

        public int? IDLoaiBaiGiang { get; set; }

        [StringLength(500)]
        public string FileName { get; set; }

        public int? FileSize { get; set; }

        public int? IDThanhVienDongGop { get; set; }

        public bool? IsHienThi { get; set; }

        public bool? IsDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? LuotXem { get; set; }

        public int? LuotTaiXuong { get; set; }

        public int? IDHinhDaiDien { get; set; }

        public int? IDTruong { get; set; }

        [StringLength(300)]
        public string SEO_URL { get; set; }

        [StringLength(200)]
        public string SEO_TITLE { get; set; }

        [StringLength(500)]
        public string SEO_MetaKey { get; set; }

        [StringLength(500)]
        public string SEO_MetaDesc { get; set; }

        public int? IDFileBaiGiang { get; set; }
    }
}
