namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_SoDoToChuc
    {
        public int ID { get; set; }

        public int? IDThamChieu { get; set; }

        [StringLength(200)]
        public string TieuDe { get; set; }

        [StringLength(300)]
        public string HinhDaiDien { get; set; }

        [StringLength(300)]
        public string LienKet { get; set; }

        public string NoiDung { get; set; }

        public int? IDNhom { get; set; }

        public int? Level { get; set; }

        public int? Ordering { get; set; }

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
