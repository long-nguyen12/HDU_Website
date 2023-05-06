namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CSV_CuuSinhVien
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(1000)]
        public string HinhDaiDien { get; set; }

        public bool? DaKetHon { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(100)]
        public string DienThoai { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(200)]
        public string UserName { get; set; }

        [StringLength(200)]
        public string Pwd { get; set; }

        public int? ForWeb { get; set; }

        public bool? IsDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDHinhDaiDien { get; set; }

        [StringLength(20)]
        public string MaSinhVien { get; set; }

        [StringLength(20)]
        public string SoCMND { get; set; }

        [StringLength(200)]
        public string NgheNghiep { get; set; }

        [StringLength(200)]
        public string NoiCongTac { get; set; }

        [StringLength(500)]
        public string DiaChiCongTac { get; set; }

        [StringLength(200)]
        public string ChucVuTrongLop { get; set; }

        [StringLength(200)]
        public string GVCN { get; set; }

        [StringLength(500)]
        public string QueQuan { get; set; }

        public int? IDCoSo { get; set; }

        public int? IDKhoa { get; set; }

        public int? IDKhoaHoc { get; set; }

        public int? IDHeDaoTao { get; set; }

        public int? IDLoaiHinhDT { get; set; }

        public int? IDNganh { get; set; }

        public int? IDNghe { get; set; }

        public int? IDLopHoc { get; set; }

        public bool? IsBanLienLac { get; set; }

        [StringLength(100)]
        public string TenKhoaHoc { get; set; }

        [StringLength(100)]
        public string TenKhoa { get; set; }

        [StringLength(100)]
        public string TenNganh { get; set; }

        [StringLength(100)]
        public string TenLopHoc { get; set; }

        [StringLength(100)]
        public string TenHeDaoTao { get; set; }

        [StringLength(100)]
        public string TenLoaiHinhDT { get; set; }
    }
}
