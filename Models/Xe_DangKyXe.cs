namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Xe_DangKyXe
    {
        public int ID { get; set; }

        public int? IDNguoiDangKy { get; set; }

        public int? IDLoaiXe { get; set; }

        public int? TrangThai { get; set; }

        public DateTime? NgayDeXuat { get; set; }

        [StringLength(200)]
        public string YeuCau { get; set; }

        public DateTime? ThoiGianBatDau { get; set; }

        public DateTime? ThoiGianKetThuc { get; set; }

        [StringLength(500)]
        public string NoiDi { get; set; }

        [StringLength(500)]
        public string NoiDen { get; set; }

        public int? SoNguoiDi { get; set; }

        [StringLength(500)]
        public string VatDungDiKem { get; set; }

        [StringLength(4000)]
        public string GhiChu { get; set; }

        public int? IDXeOto { get; set; }

        public int? IDTaiXe { get; set; }

        public int? IDDonVi { get; set; }

        public int? IDPhongBan { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDTruongDoan { get; set; }

        [StringLength(500)]
        public string MucDichSuDung { get; set; }
    }
}
