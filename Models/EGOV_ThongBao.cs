namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_ThongBao
    {
        public int ID { get; set; }

        [StringLength(2000)]
        public string TieuDe { get; set; }

        public int LoaiThongBao { get; set; }

        public DateTime? NgayHetHan { get; set; }

        public string NoiDung { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        [StringLength(50)]
        public string MaTraCuu { get; set; }

        public int? IDTinhChat { get; set; }
    }
}
