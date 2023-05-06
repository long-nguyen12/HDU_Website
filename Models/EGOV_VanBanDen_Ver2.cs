namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDen_Ver2
    {
        public int ID { get; set; }

        public int? IDLoaiVanBan { get; set; }

        public int? IDPhanLoaiVanBan { get; set; }

        public int? IDVBLT { get; set; }

        public int? IDSoVanBan { get; set; }

        [StringLength(200)]
        public string SoLuuVanBan { get; set; }

        [StringLength(200)]
        public string SoVanBanDen { get; set; }

        [StringLength(2000)]
        public string TrichYeu { get; set; }

        public DateTime? NgayBanHanh { get; set; }

        [StringLength(500)]
        public string CoQuanBanHanh { get; set; }

        public int? IDKhoiCoQuanGui { get; set; }

        public int? IDCoQuanGui { get; set; }

        public DateTime? NgayKy { get; set; }

        [StringLength(250)]
        public string NguoiKy { get; set; }

        [StringLength(200)]
        public string ChucVuNguoiKy { get; set; }

        public DateTime? NgayNhan { get; set; }

        public int? HinhThucNhan { get; set; }

        [StringLength(300)]
        public string LinhVuc { get; set; }

        public int? SoTrang { get; set; }

        public int? TinhChat { get; set; }

        public int? BaoMat { get; set; }

        public DateTime? ThoiHanXuLy { get; set; }

        [StringLength(100)]
        public string SoKe { get; set; }

        [StringLength(100)]
        public string ThuTuTrongKe { get; set; }

        [StringLength(100)]
        public string SoHop { get; set; }

        [StringLength(100)]
        public string ThuTuTrongHop { get; set; }

        [StringLength(100)]
        public string MaVanBanDT { get; set; }

        public int? IDHoSoDonVi { get; set; }

        [StringLength(500)]
        public string NoiLuuTru { get; set; }

        public int? IDNguoiCapNhatHTVB { get; set; }

        public DateTime? NgayCapNhatHTVB { get; set; }

        public bool? IsDaButPhe { get; set; }

        public int? IDNguoiButPhe { get; set; }

        public DateTime? NgayButPhe { get; set; }

        [StringLength(500)]
        public string NoiDungButPhe { get; set; }

        public bool? IsDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public string GhiChuDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public int? IDTrangThai { get; set; }

        public string GhiChu { get; set; }

        public bool? IsReadonly { get; set; }

        public bool? IsBanChinh { get; set; }

        public bool? IsThongBao { get; set; }

        public int? IDThongBao { get; set; }

        public bool? IsCoVanBanGiay { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public bool? IsHoanThanh { get; set; }
    }
}
