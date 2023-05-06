namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ES_NhomNhanSu
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string MaNhom { get; set; }

        [StringLength(200)]
        public string TenNhom { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public bool? IsSinhHoatDang { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsRoot { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDDonVi { get; set; }

        public int? SoThuTu { get; set; }
    }
}
