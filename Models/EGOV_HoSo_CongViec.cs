namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_HoSo_CongViec
    {
        public int ID { get; set; }

        public int? IDLoaiHoSo { get; set; }

        [StringLength(200)]
        public string MaHoSo { get; set; }

        [StringLength(2000)]
        public string TieuDe { get; set; }

        public DateTime? NgayTaoHoSo { get; set; }

        public DateTime? HanXuLy { get; set; }

        public int? IDTrangThai { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public string GhiChu { get; set; }

        public string GhiChuChuyenTrangThai { get; set; }
    }
}
