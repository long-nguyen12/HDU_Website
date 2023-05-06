namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KH_YeuCau
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string MaYeuCau { get; set; }

        [Required]
        [StringLength(1000)]
        public string ChuDe { get; set; }

        public string MoTa { get; set; }

        public int IDPhanHe { get; set; }

        public int IDKhachHang { get; set; }

        public int IDLoai { get; set; }

        public int IDTrangThai { get; set; }

        public int IDDoUuTien { get; set; }

        public int IDDoNghiemTrong { get; set; }

        public int? IDPhongBanXuLy { get; set; }

        public int? IDNguoiTiepNhan { get; set; }

        public DateTime? NgayTiepNhan { get; set; }

        [StringLength(500)]
        public string NguoiYeuCau { get; set; }

        public int? DinhKemDK { get; set; }

        public int? DaXemDX { get; set; }

        public bool? NghiepVu { get; set; }

        public DateTime? NgayXuLy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMongMuon { get; set; }

        [StringLength(50)]
        public string Version { get; set; }

        public int? IDRelease { get; set; }

        public int? IDTrangThaiPhieuYeuCau { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
