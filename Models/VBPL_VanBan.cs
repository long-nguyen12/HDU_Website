namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VBPL_VanBan
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string SoKyHieu { get; set; }

        [StringLength(1000)]
        public string TrichYeu { get; set; }

        public DateTime? NgayBanHanh { get; set; }

        public DateTime? NgayHieuLuc { get; set; }

        public DateTime? NgayHetHieuLuc { get; set; }

        public DateTime? NgayDangCongBao { get; set; }

        [StringLength(200)]
        public string NguoiKy { get; set; }

        public DateTime? NgayKy { get; set; }

        public int? IDLoaiVB { get; set; }

        public int? IDTrangThai { get; set; }

        public int? IDCoQuanBH { get; set; }

        public int? IDLinhVuc { get; set; }

        public int? IDNganh { get; set; }

        public int? IDPhamVi { get; set; }

        [StringLength(500)]
        public string NguonThuThap { get; set; }

        public bool? IsHienThi { get; set; }

        public bool? IsDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        [Required]
        [StringLength(300)]
        public string Alias { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(500)]
        public string MetaKey { get; set; }

        [StringLength(500)]
        public string MetaDesc { get; set; }
    }
}
