namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_TableImportDetail
    {
        public int ID { get; set; }

        public int? IDThamChieu { get; set; }

        public bool? IsImport { get; set; }

        [StringLength(200)]
        public string DienGiai { get; set; }

        [StringLength(100)]
        public string TenField { get; set; }

        [StringLength(100)]
        public string LoaiDuLieu { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public bool? IsBatBuoc { get; set; }

        public bool? IsKiemTrung { get; set; }

        public int? DoDaiChuoi { get; set; }

        public int? Precision { get; set; }

        public decimal? GiaTriMin { get; set; }

        public decimal? GiaTriMax { get; set; }

        [StringLength(1000)]
        public string ScripSql { get; set; }

        [StringLength(1000)]
        public string EnumData { get; set; }

        public int? Scale { get; set; }

        [StringLength(20)]
        public string NgayFormat { get; set; }

        public int? SoThuTu { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
