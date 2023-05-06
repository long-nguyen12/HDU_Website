namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SV_NhatKyVaoTruong
    {
        public int Id { get; set; }

        public int? IDSinhVien { get; set; }

        [StringLength(100)]
        public string SoDienThoai { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public int? DCTT_IDTinh { get; set; }

        public int? DCTT_IDHuyen { get; set; }

        public int? DCTT_IDPhuongXa { get; set; }

        [StringLength(2000)]
        public string DCTT_SoNha { get; set; }

        public int? IDCoSo { get; set; }

        public DateTime? NgayVaoTruong { get; set; }

        public int? IDLyDoVaoTruong { get; set; }

        [StringLength(2000)]
        public string IDLichHocList { get; set; }

        [StringLength(2000)]
        public string IDLichThiList { get; set; }

        [StringLength(200)]
        public string LyDoKhac { get; set; }

        public bool? TieuChi01 { get; set; }

        public bool? TieuChi02 { get; set; }

        public bool? TieuChi03 { get; set; }

        public bool? TieuChi04 { get; set; }

        public bool? TieuChi05 { get; set; }

        public bool? TieuChi06 { get; set; }

        public bool? TieuChi07 { get; set; }

        public bool? TieuChi08 { get; set; }

        public bool? TieuChi09 { get; set; }

        public bool? TieuChi10 { get; set; }

        public bool? TieuChi11 { get; set; }

        public bool? TieuChi12 { get; set; }

        public bool? TieuChi13 { get; set; }

        public bool? TieuChi14 { get; set; }

        public bool? TieuChi15 { get; set; }

        [StringLength(200)]
        public string GhiChu01 { get; set; }

        [StringLength(200)]
        public string GhiChu02 { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayVaoTruongNoTime { get; set; }
    }
}
