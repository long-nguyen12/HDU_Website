namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_DM_PhieuDanhGiaChiTiet
    {
        public int ID { get; set; }

        public int? IDPhieuDanhGia { get; set; }

        public int? SoThuTu { get; set; }

        [StringLength(2000)]
        public string NoiDung { get; set; }

        public decimal? DiemToiDa { get; set; }

        [StringLength(2000)]
        public string GhiChu { get; set; }

        public int? IDParent { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public decimal? HeSoDiem { get; set; }
    }
}
