namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOB_UngVien
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

        [StringLength(300)]
        public string ViTriLamMongMuon { get; set; }

        public int? IDMucLuongMongMuon { get; set; }

        public int? IDCapBacMongMuon { get; set; }

        public int? SoNamKinhNghiem { get; set; }

        public bool? IsChuaCoKinhNghiem { get; set; }

        public string MucTieuCongViec { get; set; }

        public string KyNang { get; set; }

        public int? IDQuocTich { get; set; }

        public int? IDHuyen { get; set; }

        public int? IDTruong { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        [StringLength(200)]
        public string PWD { get; set; }

        public bool? IsDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public int? IDHinhDaiDien { get; set; }
    }
}
