namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASC_HopDongGiaiDoan_TrangThai
    {
        public int ID { get; set; }

        [Required]
        [StringLength(500)]
        public string TenTrangThaiGD { get; set; }

        [StringLength(500)]
        public string VietTat { get; set; }

        public int? ThuTu { get; set; }

        [StringLength(10)]
        public string MaMau { get; set; }

        public bool? IsDefault { get; set; }

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
