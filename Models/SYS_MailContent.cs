namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_MailContent
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        [StringLength(500)]
        public string TieuDe { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        public int? IDBieuMauDinhKem01 { get; set; }

        public int? IDBieuMauDinhKem02 { get; set; }

        public bool? IsVisible { get; set; }

        [StringLength(200)]
        public string DsIDMail { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
