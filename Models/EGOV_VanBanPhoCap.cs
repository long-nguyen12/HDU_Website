namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanPhoCap
    {
        public int ID { get; set; }

        public int? IDLoaiVanBan { get; set; }

        public int? IDHinhThucVanBan { get; set; }

        [StringLength(500)]
        public string SoLuuVanBan { get; set; }

        [StringLength(4000)]
        public string TrichYeu { get; set; }

        public DateTime? NgayKy { get; set; }

        public int? FileAttach { get; set; }

        [StringLength(4000)]
        public string NoiPhatHanh { get; set; }

        [StringLength(4000)]
        public string Tag { get; set; }

        public string GhiChu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
