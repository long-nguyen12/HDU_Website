namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_DM_Xe
    {
        public int ID { get; set; }

        public int? IDLoaiXe { get; set; }

        public int? IDTaiXe { get; set; }

        [StringLength(500)]
        public string TenXe { get; set; }

        [StringLength(100)]
        public string HieuXe { get; set; }

        [StringLength(100)]
        public string SoXe { get; set; }

        public int? SoChoNgoi { get; set; }

        [StringLength(1000)]
        public string MoTa { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? SoThuTu { get; set; }

        public bool? IsKichHoat { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
