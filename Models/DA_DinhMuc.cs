namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DA_DinhMuc
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string MaDinhMuc { get; set; }

        public string TenDinhMuc { get; set; }

        [StringLength(50)]
        public string ThoiGian { get; set; }

        [StringLength(50)]
        public string DoKho { get; set; }

        public string MoTa { get; set; }

        public int? ThoiGianVal { get; set; }

        public int? DoKhoVal { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public bool? IsDefault { get; set; }
    }
}
