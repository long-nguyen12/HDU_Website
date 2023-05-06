namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_GiaoViecTrangThaiXuKy
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string TenTrangThai { get; set; }

        public int? ThuTu { get; set; }

        [StringLength(10)]
        public string MaMau { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public bool? IsHienThi { get; set; }

        public int? LoaiTrangThai { get; set; }
    }
}
