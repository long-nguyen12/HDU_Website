namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOB_FORM_LoaiDonMau
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MaLoaiDon { get; set; }

        [StringLength(300)]
        public string TenLoaiDon { get; set; }

        public string GhiChu { get; set; }

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
