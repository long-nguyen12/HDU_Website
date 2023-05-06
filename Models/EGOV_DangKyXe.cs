namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_DangKyXe
    {
        public int ID { get; set; }

        public int? IDNguoiDangKy { get; set; }

        public int? IDLoaiXe { get; set; }

        public DateTime ThoiGianBatDau { get; set; }

        public DateTime ThoiGianKetThuc { get; set; }

        public int IDMucDichSuDung { get; set; }

        [Required]
        [StringLength(1000)]
        public string MucDichKhac { get; set; }

        [Required]
        [StringLength(1000)]
        public string NoiDi { get; set; }

        [Required]
        [StringLength(1000)]
        public string NoiDen { get; set; }

        public int SoNguoiDi { get; set; }

        [Required]
        [StringLength(1000)]
        public string VatDungDiKem { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int IDPhongBan { get; set; }

        public int IDNguoiPheDuyet { get; set; }

        [Required]
        [StringLength(1000)]
        public string YKienNguoiPheDuyet { get; set; }

        public int IDNguoiDieuPhoi { get; set; }

        [StringLength(1000)]
        public string YKienNguoiDieuPhoi { get; set; }

        public int? IDTrangThai { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
