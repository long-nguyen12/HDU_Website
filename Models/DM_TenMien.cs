namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_TenMien
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string TenMien { get; set; }

        public bool? IsSubDomain { get; set; }

        [StringLength(100)]
        public string DiaChiIP { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public DateTime? NgayHetHan { get; set; }

        public bool? IsKichHoat { get; set; }

        public int? SoThuTu { get; set; }

        public int? IDNhaCungCap { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
