namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_ThongBao_TinhChat
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MaTinhChat { get; set; }

        [StringLength(200)]
        public string TenTinhChat { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        [StringLength(10)]
        public string MaMau { get; set; }

        public int? STT { get; set; }

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
