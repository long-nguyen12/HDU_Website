namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TL_TaiLieu
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string TieuDe { get; set; }

        [StringLength(200)]
        public string VietTat { get; set; }

        public string NoiDung { get; set; }

        public int? Ordering { get; set; }

        public int? Level { get; set; }

        public int? IDDanhMuc { get; set; }

        public int? IDParent { get; set; }

        public bool? IsHienThi { get; set; }

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
