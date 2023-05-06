namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Express_DeXuatChuyenPhat
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MaCPN { get; set; }

        public DateTime? NgayDeXuat { get; set; }

        [StringLength(200)]
        public string TenHang { get; set; }

        public DateTime? ThoiGianChuyen { get; set; }

        public DateTime? ThoiGianNhan { get; set; }

        public int? IDLoaiChuyenPhat { get; set; }

        [StringLength(150)]
        public string NguoiNhan { get; set; }

        [StringLength(50)]
        public string DienThoaiNguoiNhan { get; set; }

        [StringLength(150)]
        public string DiaChiNguoiNhan { get; set; }

        public decimal? TrongLuong { get; set; }

        public int? SoLuong { get; set; }

        public DateTime? NgayNhanCPN { get; set; }

        [StringLength(150)]
        public string NoiDen { get; set; }

        [StringLength(50)]
        public string NguoiKyNhan { get; set; }

        public DateTime? NgayKyNhan { get; set; }

        [StringLength(50)]
        public string DienThoaiNguoiKyNhan { get; set; }

        [StringLength(50)]
        public string SoBill { get; set; }

        public decimal? DonGia { get; set; }

        public decimal? TienDongGoi { get; set; }

        public decimal? PhuPhi { get; set; }

        public decimal? VAT { get; set; }

        public int? IDCongTyCPN { get; set; }

        public int? IDBangGiaCPN { get; set; }

        public int? IDTinhThanh { get; set; }

        public int? IDQuocGia { get; set; }

        public int? TrangThai { get; set; }

        public bool? IsDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public int? SoThuTu { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDNoiDen { get; set; }

        public int? IDLoaiHang { get; set; }

        public int? IDPhongBanDeXuat { get; set; }
    }
}
