namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_DangKySuDungXe
    {
        public int ID { get; set; }

        public int? IDLoaiXe { get; set; }

        [StringLength(500)]
        public string TieuDe { get; set; }

        public DateTime TuNgay { get; set; }

        public DateTime DenNgay { get; set; }

        [StringLength(500)]
        public string DiaDiem { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        public int? TrangThai { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }
    }
}
