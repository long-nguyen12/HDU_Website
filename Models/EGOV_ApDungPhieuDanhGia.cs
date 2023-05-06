namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_ApDungPhieuDanhGia
    {
        public int ID { get; set; }

        public int? IDDotDanhGia { get; set; }

        public int? IDPhieuDanhGia { get; set; }

        public int? IDNguoiThucHien { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public DateTime? NgayTuDanhGia { get; set; }

        public DateTime? NgayQuanLy01 { get; set; }

        public DateTime? NgayQuanLy03 { get; set; }

        public DateTime? NgayQuanLy02 { get; set; }

        public int? IDNguoiQuanLy01 { get; set; }

        public int? IDNguoiQuanLy02 { get; set; }

        public int? IDNguoiQuanLy03 { get; set; }
    }
}
