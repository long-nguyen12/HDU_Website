namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ads_LinhVuc
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MaLinhVucQC { get; set; }

        [StringLength(500)]
        public string TenLinhVucQC { get; set; }

        public byte? TuDoTuoi { get; set; }

        public byte? DenDoTuoi { get; set; }

        public bool? GioiTinh { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? ForWeb { get; set; }
    }
}
