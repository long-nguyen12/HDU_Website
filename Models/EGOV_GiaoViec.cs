namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_GiaoViec
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string MaCongViec { get; set; }

        [StringLength(2000)]
        public string TenCongViec { get; set; }

        public int? IDNguoiGiamSat { get; set; }

        public DateTime? TuNgay { get; set; }

        public DateTime? DenNgay { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        public bool? IsHoanThanh { get; set; }

        public int? TrangThaiGiaoViec { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDNguoiGiao { get; set; }
    }
}
