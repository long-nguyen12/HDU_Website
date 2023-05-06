namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ads_ScriptKey
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string ScriptKey { get; set; }

        public int? IDKhachHang { get; set; }

        public int? IDPhanHe { get; set; }

        public int? IDViTri { get; set; }

        public bool? GioiTinh { get; set; }

        public int? MaxAds { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? SoLanHienThiSeAnQuangCao { get; set; }
    }
}
