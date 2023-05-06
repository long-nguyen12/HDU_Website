namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_NhomCauHinh
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Ma { get; set; }

        [StringLength(200)]
        public string TenNhom { get; set; }

        public string HinhDaiDien { get; set; }

        public string MoTa { get; set; }

        public int? SoThuTu { get; set; }

        public int? IDGiaoDien { get; set; }

        [StringLength(50)]
        public string MaGiaoDien { get; set; }

        public int? IDThamChieu { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public string DataHinhDaiDien { get; set; }
    }
}
