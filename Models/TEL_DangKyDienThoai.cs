namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEL_DangKyDienThoai
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        public decimal? DinhMuc { get; set; }

        public int? IDNguoiSuDung { get; set; }

        public int? IDDonVi { get; set; }

        public int? IDPhongBan { get; set; }

        public int? IDGoiCuoc { get; set; }

        public int? SoThuTu { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDMang { get; set; }

        public int? DoiTuongSD { get; set; }
    }
}
