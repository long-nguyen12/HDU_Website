namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HoiDap_CauHoi
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string HoTen { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(500)]
        public string SoDienThoai { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(50)]
        public string SoCMND { get; set; }

        [StringLength(4000)]
        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        public int? IDDonVi { get; set; }

        public int? IDLinhVuc { get; set; }

        public int? SoThuTu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

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

        public bool? IsDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public int? LuotXem { get; set; }
    }
}
