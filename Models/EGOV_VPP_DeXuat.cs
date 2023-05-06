namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VPP_DeXuat
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MaDeXuat { get; set; }

        public DateTime? NgayDeXuat { get; set; }

        public int? IDPhongBan { get; set; }

        public int? LoaiDeXuat { get; set; }

        public int? TrangThai { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public DateTime? NgayGiaoHang { get; set; }

        public int? IDNhaCungCap { get; set; }

        public DateTime? NgayDatHang { get; set; }

        [StringLength(50)]
        public string MaHoaDon { get; set; }

        [StringLength(2000)]
        public string GhiChu { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDNguoiDatHang { get; set; }

        public DateTime? NgayGiaoHangDuKien { get; set; }
    }
}
