namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KH_DotRelease
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string MaRelease { get; set; }

        public DateTime NgayRelease { get; set; }

        public int? IDNguoiPhuTrach { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? IDPhanHe { get; set; }

        public int? IDKhachHang { get; set; }

        public int? TrangThai { get; set; }

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
