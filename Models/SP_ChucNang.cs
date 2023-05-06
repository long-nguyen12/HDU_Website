namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SP_ChucNang
    {
        public int ID { get; set; }

        public int? IDPhanHe { get; set; }

        [StringLength(200)]
        public string MaManHinh { get; set; }

        [StringLength(200)]
        public string MaManHinhMoi { get; set; }

        [StringLength(1000)]
        public string TenManHinh { get; set; }

        [StringLength(1000)]
        public string TenChucNang { get; set; }

        [StringLength(4000)]
        public string MoTa { get; set; }

        public string NoiDung { get; set; }

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
