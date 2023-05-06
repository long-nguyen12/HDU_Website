namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDiDang
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string SoLuuCongVan { get; set; }

        [StringLength(200)]
        public string SoCongVanDi { get; set; }

        [StringLength(2000)]
        public string TrichYeu { get; set; }

        public DateTime? NgayCV { get; set; }

        [StringLength(200)]
        public string TraLoiCongVanSo { get; set; }

        public DateTime? NgayTraLoiCV { get; set; }

        public int? SoBan { get; set; }

        public int? IDNguoiKy { get; set; }

        [StringLength(250)]
        public string NguoiKy { get; set; }

        public DateTime? NgayKy { get; set; }

        public int? IDLoaiCongVan { get; set; }

        public int? IDKhoiCoQuanNhan { get; set; }

        public int? IDCoQuanNhan { get; set; }

        public int? IDCongVanDen { get; set; }

        public int? IDDonViSoan { get; set; }

        public int? IDHoSoDonVi { get; set; }

        public int? TrangThai { get; set; }

        public int? TinhChat { get; set; }

        public int? BaoMat { get; set; }

        [StringLength(500)]
        public string NguoiGui { get; set; }

        public int? HinhThucGui { get; set; }

        [StringLength(300)]
        public string LinhVuc { get; set; }

        public bool? IsNhanBanCung { get; set; }

        public int? IDVanBanDen { get; set; }

        public int? IDCanBoSoan { get; set; }

        [StringLength(500)]
        public string NoiLuuTru { get; set; }

        public string GhiChu { get; set; }

        public DateTime? NgayNhap { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? SoTrang { get; set; }
    }
}
