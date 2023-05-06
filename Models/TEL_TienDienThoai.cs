namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEL_TienDienThoai
    {
        public int ID { get; set; }

        public int? Thang { get; set; }

        public int? Nam { get; set; }

        public int? IDDangKyDienThoai { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        public decimal? DinhMuc { get; set; }

        public decimal? ThucTe { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? IDNguoiSuDung { get; set; }

        public int? IDDonViSuDung { get; set; }

        public int? IDPhongBanSuDung { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public decimal? TienXinGiam { get; set; }

        [StringLength(500)]
        public string LyDoXinGiam { get; set; }

        public bool? IsDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public decimal? TienDuocDuyet { get; set; }

        [StringLength(500)]
        public string GhiChuDuyet { get; set; }
    }
}
