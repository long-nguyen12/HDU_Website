namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KH_ThongBaoBaoTri
    {
        public int ID { get; set; }

        [Required]
        [StringLength(300)]
        public string TieuDe { get; set; }

        public string NoiDungThongBao { get; set; }

        public DateTime? NgayKetThucHD { get; set; }

        public bool? IsThongBao { get; set; }

        public int? IDKhachHang { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
