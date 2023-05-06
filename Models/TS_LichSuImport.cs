namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TS_LichSuImport
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string DuongDanSaveFileImport { get; set; }

        [StringLength(200)]
        public string TenFileUpLoad { get; set; }

        [StringLength(200)]
        public string TenFileImport { get; set; }

        public DateTime? ThoiGianBatDau { get; set; }

        public DateTime? ThoiGianKetThuc { get; set; }

        public int? SoLuongInsert { get; set; }

        public int? SoLuongUpdate { get; set; }

        public int? SoLuongInsertThanhCong { get; set; }

        public int? SoLuongUpdateThanhCong { get; set; }

        public int? LoaiImport { get; set; }

        public int? TrangThai { get; set; }

        public string LogError { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? SoLuongImport { get; set; }
    }
}
