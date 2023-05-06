namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_SendMailHistory
    {
        public long ID { get; set; }

        public int? NguonGuiMail { get; set; }

        public int? IDThamChieu { get; set; }

        public int? IDEmailContent { get; set; }

        [StringLength(200)]
        public string EmailNhan { get; set; }

        [Column(TypeName = "ntext")]
        public string DuLieuNhan { get; set; }

        public bool? IsDaGui { get; set; }

        public DateTime? NgayXacNhan { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? LoaiThongTinGui { get; set; }

        public bool? IsDaDongBo { get; set; }

        public int? IDMailGui { get; set; }
    }
}
