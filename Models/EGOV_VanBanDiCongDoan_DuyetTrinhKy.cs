namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDiCongDoan_DuyetTrinhKy
    {
        public int ID { get; set; }

        public int? IDVanBanDiCongDoan { get; set; }

        [StringLength(2000)]
        public string NoiDungPhanHoi { get; set; }

        public int? TrangThaiCu { get; set; }

        public int? TrangThaiMoi { get; set; }

        public int? IDNguoiTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }
    }
}
