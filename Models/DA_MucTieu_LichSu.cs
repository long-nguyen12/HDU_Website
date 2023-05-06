namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DA_MucTieu_LichSu
    {
        public int ID { get; set; }

        public int IDMucTieu { get; set; }

        public DateTime Ngay { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? IDTrangThaiCu { get; set; }

        public int? IDTrangThaiMoi { get; set; }

        public int? PhanTramHoanThanhCu { get; set; }

        public int? PhanTramHoanThanhMoi { get; set; }

        public DateTime? BatDauCu { get; set; }

        public DateTime? BatDauMoi { get; set; }

        public DateTime? KetThucCu { get; set; }

        public DateTime? KetThucMoi { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
