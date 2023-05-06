namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KH_DotRelease_LichSu
    {
        public int ID { get; set; }

        public int IDDotRelease { get; set; }

        public DateTime? NgayReleaseCu { get; set; }

        public DateTime? NgayReleaseMoi { get; set; }

        public int? IDTrangThaiCu { get; set; }

        public int? IDTrangThaiNew { get; set; }

        [StringLength(1000)]
        public string NoiDung { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
