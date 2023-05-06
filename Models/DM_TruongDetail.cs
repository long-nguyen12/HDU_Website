namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_TruongDetail
    {
        public int ID { get; set; }

        public int? IDTruong { get; set; }

        public int? ChiTieuTuyenSinh { get; set; }

        public decimal? HocPhiThamKhaoTu { get; set; }

        public decimal? HocPhiThamKhaoDen { get; set; }

        public DateTime? NgayNhapHocDuKien { get; set; }

        public int? NamApDung { get; set; }

        public int? ForWeb { get; set; }

        public bool? IsDuyet { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
