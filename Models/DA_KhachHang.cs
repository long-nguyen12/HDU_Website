namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DA_KhachHang
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string TenKhachHang { get; set; }

        [StringLength(500)]
        public string TenDayDu { get; set; }

        public string GhiChu { get; set; }

        [StringLength(300)]
        public string DiaChi { get; set; }

        [StringLength(300)]
        public string SoDienThoai { get; set; }

        [StringLength(100)]
        public string Fax { get; set; }

        public string ThongTinLienHe { get; set; }

        public bool? Del_YN { get; set; }

        public bool? ThauPhu { get; set; }

        public int? IDKhuVuc { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        [StringLength(50)]
        public string MaMap { get; set; }

        public int? SoThuTu { get; set; }

        public int? IDHeThongPayment { get; set; }

        public int? IDGroupDVLienKet { get; set; }
    }
}
