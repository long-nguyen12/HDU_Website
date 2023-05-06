namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDenDoanThanhNienPhanCongXuLy
    {
        public int ID { get; set; }

        public int? IDThamChieu { get; set; }

        public int? IDVanBanDenDoanThanhNien { get; set; }

        public int? IDNguoiNhan { get; set; }

        public DateTime? NgayXem { get; set; }

        public int? LoaiDoiTuong { get; set; }

        public bool? IsDonViXuLy { get; set; }

        public int? IDNguoiChiDao { get; set; }

        public DateTime? NgayChiDao { get; set; }

        public string YKienChiDao { get; set; }

        public int? IDNguoiBaoCao { get; set; }

        public DateTime? NgayBaoCao { get; set; }

        public string BaoCao { get; set; }

        public int? IDNguoiPhanHoi { get; set; }

        public DateTime? NgayPhanHoi { get; set; }

        public string NoiDungPhanHoi { get; set; }

        public int? TrangThai { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
