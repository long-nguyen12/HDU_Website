namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ELN_LichHoc
    {
        public int ID { get; set; }

        [StringLength(2000)]
        public string TieuDe { get; set; }

        public DateTime TuNgay { get; set; }

        public DateTime DenNgay { get; set; }

        public bool? CaNgay { get; set; }

        [StringLength(1000)]
        public string DiaDiem { get; set; }

        [StringLength(4000)]
        public string GhiChu { get; set; }

        public string NoiDung { get; set; }

        public int? LoaiCongTac { get; set; }

        [StringLength(12)]
        public string MauSac { get; set; }

        [StringLength(12)]
        public string MauNen { get; set; }

        public bool? IsPublic { get; set; }

        public bool? IsLichDeXuat { get; set; }

        public int? IDDonVi { get; set; }

        public int? IDPhongBan { get; set; }

        public int? IDPhongHop { get; set; }

        public int? IDNguoiChuTri { get; set; }

        [StringLength(500)]
        public string NguoiChuTriEx { get; set; }

        [StringLength(1500)]
        public string NguoiThamDuEx { get; set; }

        public string ThanhPhanBenNgoai { get; set; }

        public string StartURL { get; set; }

        public string JoinURL { get; set; }

        public string DuLieuNhan { get; set; }

        public int? IDNguoiDuyetDeXuat { get; set; }

        public DateTime? NgayDuyetDeXuat { get; set; }

        public int? TrangThaiDeXuat { get; set; }

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
