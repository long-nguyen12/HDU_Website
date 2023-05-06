namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOB_FORM_DonMau
    {
        public int ID { get; set; }

        public int? IDLoaiDonMau { get; set; }

        [StringLength(500)]
        public string TenDon { get; set; }

        [StringLength(2000)]
        public string MoTa { get; set; }

        public int? IDHinhDaiDien { get; set; }

        public string IDsHinhMau { get; set; }

        public int? SoLuotXem { get; set; }

        public int? SoLuotTai { get; set; }

        public bool? IsHienThi { get; set; }

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
