namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_KetQuaDanhGia
    {
        public int ID { get; set; }

        public int? IDNguoiThucHien { get; set; }

        public int? IDApDungPhieuDanhGia { get; set; }

        public int? IDPhieuDanhGiaChiTiet { get; set; }

        public decimal? DiemTuDanhGia { get; set; }

        [StringLength(2000)]
        public string GhiChuTuDanhGia { get; set; }

        public DateTime? NgayTuDanhGia { get; set; }

        public decimal? DiemQuanLy01 { get; set; }

        [StringLength(2000)]
        public string GhiChuQuanLy01 { get; set; }

        public DateTime? NgayQuanLy01 { get; set; }

        public int? IDNguoiQuanLy01 { get; set; }

        public decimal? DiemQuanLy02 { get; set; }

        [StringLength(2000)]
        public string GhiChuQuanLy02 { get; set; }

        public DateTime? NgayQuanLy02 { get; set; }

        public int? IDNguoiQuanLy02 { get; set; }

        public decimal? DiemQuanLy03 { get; set; }

        [StringLength(2000)]
        public string GhiChuQuanLy03 { get; set; }

        public DateTime? NgayQuanLy03 { get; set; }

        public int? IDNguoiQuanLy03 { get; set; }

        public decimal? DiemDanhGia { get; set; }

        [StringLength(2000)]
        public string GhiChu { get; set; }

        public int? NguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? IDLuaChonTuDangGia { get; set; }

        public int? IDLuaChonQuanLy01 { get; set; }

        public int? IDLuaChonQuanLy02 { get; set; }

        public int? IDLuaChonQuanLy03 { get; set; }

        public int? IDLuaChon { get; set; }
    }
}
