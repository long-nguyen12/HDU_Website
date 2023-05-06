namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_DM_LuaChon
    {
        public int ID { get; set; }

        public int? IDNhomLuaChon { get; set; }

        [StringLength(200)]
        public string TenLuaChon { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public bool? IsBatBuocNhapNhanXet { get; set; }

        public bool? IsVisible { get; set; }

        public decimal? DiemLuaChon { get; set; }

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
