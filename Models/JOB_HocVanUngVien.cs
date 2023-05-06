namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOB_HocVanUngVien
    {
        public int ID { get; set; }

        public int? IDUngVien { get; set; }

        [StringLength(1000)]
        public string TenBangCapChungChi { get; set; }

        [StringLength(1000)]
        public string ChuyenNganhDaoTao { get; set; }

        public int? IDTruong { get; set; }

        public int? IDKhoaDaoTao { get; set; }

        public int? IDXepLoai { get; set; }

        public DateTime? BatDau { get; set; }

        public DateTime? KetThuc { get; set; }

        public string ThongTinThem { get; set; }

        public int? SoThuTu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
