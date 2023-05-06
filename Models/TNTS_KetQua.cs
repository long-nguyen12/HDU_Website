namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TNTS_KetQua
    {
        public int ID { get; set; }

        public int? IDThanhVien { get; set; }

        public int? IDNhomCauHoi { get; set; }

        [StringLength(100)]
        public string NguoiThucHien { get; set; }

        public int? DiemSo { get; set; }

        [StringLength(100)]
        public string IPAddress { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
