namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UngVien")]
    public partial class UngVien
    {
        public int ID { get; set; }

        public int? IDKeHoachTuyenDung_ChiTiet { get; set; }

        [StringLength(100)]
        public string HoDem { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        public bool? GioiTinh { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        public int? IDTrangThai { get; set; }

        public DateTime? NgayPhongVan { get; set; }

        public bool? IsLienHe { get; set; }

        [StringLength(500)]
        public string GhiChuLienHe { get; set; }

        public bool? IsPhongVan { get; set; }

        [StringLength(500)]
        public string GhiChuPhongVan { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDViTriViecLam { get; set; }
    }
}
