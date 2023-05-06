namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APP_Notify
    {
        public int ID { get; set; }

        public int? IDUser { get; set; }

        [StringLength(500)]
        public string TieuDe { get; set; }

        [StringLength(4000)]
        public string NoiDung { get; set; }

        public int? LoaiNotify { get; set; }

        public int? IDMap { get; set; }

        public DateTime? NgayNhan { get; set; }

        public bool? IsDaXem { get; set; }

        public DateTime? NgayXem { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
