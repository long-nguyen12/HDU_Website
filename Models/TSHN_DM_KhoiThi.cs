namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TSHN_DM_KhoiThi
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string KhoiThi { get; set; }

        public int? IDMonThi1 { get; set; }

        public int? IDMonThi2 { get; set; }

        public int? IDMonThi3 { get; set; }

        public bool? IsHienThi { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDTruong { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
