namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_GiaoViecNhatKy
    {
        public int ID { get; set; }

        public int? IDGiaoViec { get; set; }

        public int? TrangThaiCu { get; set; }

        public int? TrangThaiMoi { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
