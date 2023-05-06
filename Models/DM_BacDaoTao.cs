namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_BacDaoTao
    {
        public int ID { get; set; }

        public int? IDHinhThucDaoTao { get; set; }

        [StringLength(20)]
        public string MaBacDaoTao { get; set; }

        [StringLength(100)]
        public string TenBacDaoTao { get; set; }

        [StringLength(100)]
        public string TenVietTat { get; set; }

        [StringLength(100)]
        public string TenTiengAnh { get; set; }

        public string MoTa { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public int? SoThuTu { get; set; }

        public bool? IsHienThi { get; set; }

        public int? ForWeb { get; set; }

        public int? IDTruong { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
