namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DA_CongViec
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string MaCongViec { get; set; }

        [StringLength(500)]
        public string ChuDeCongViec { get; set; }

        public string MoTa { get; set; }

        public int? IDCongViecCha { get; set; }

        public int? IDDuAnModule { get; set; }

        public int? IDDuAnTrienKhai { get; set; }

        public int? IDKhachHang { get; set; }

        public int IDLoai { get; set; }

        public int IDTrangThai { get; set; }

        public int IDDoUuTien { get; set; }

        public int? DoKho { get; set; }

        public int? PhuTrachNS { get; set; }

        public DateTime? BatDau { get; set; }

        public DateTime? HetHan { get; set; }

        public double? SoNgayCong { get; set; }

        public int TienDo { get; set; }

        public int? DaXemDX { get; set; }

        public decimal? Diem_DEV { get; set; }

        public decimal? Diem_LEA { get; set; }

        public decimal? DiemTB { get; set; }

        public int? IDVersion { get; set; }

        [StringLength(50)]
        public string Version { get; set; }

        [StringLength(50)]
        public string MaYeuCau { get; set; }

        public int? IDKH_YeuCau { get; set; }

        public int? SoGioLam { get; set; }

        public int? YCYN { get; set; }

        public int? IDDinhMuc { get; set; }

        public int? IDNhom { get; set; }

        public bool? GuiBaoCao_YN { get; set; }

        public int? IDPhuTrach { get; set; }

        public int? IDPhongBanNhan { get; set; }

        public int? IDPhongBanGiao { get; set; }

        [StringLength(200)]
        public string TenPhongBanNhan { get; set; }

        [StringLength(200)]
        public string TenPhongBanGiao { get; set; }

        public int? ChiPhiPhatSinh { get; set; }

        public DateTime? GiaHan1 { get; set; }

        public DateTime? GiaHan2 { get; set; }

        [StringLength(200)]
        public string NoiDungGiaHan1 { get; set; }

        [StringLength(200)]
        public string NoiDungGiaHan2 { get; set; }

        public DateTime? NgayTaoGiaHan1 { get; set; }

        public DateTime? NgayTaoGiaHan2 { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDMucTieu { get; set; }
    }
}
