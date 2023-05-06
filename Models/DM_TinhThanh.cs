namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_TinhThanh
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MaTinh { get; set; }

        [Required]
        [StringLength(300)]
        public string TenTinhThanh { get; set; }

        [StringLength(300)]
        public string VietTat { get; set; }

        public int? SoThuTu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDKhuVuc { get; set; }
    }
}
