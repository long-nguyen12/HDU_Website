namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_TD_ViTriViecLam
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Ma { get; set; }

        [StringLength(200)]
        public string Ten { get; set; }

        public int? STT { get; set; }

        [StringLength(4000)]
        public string YeuCau { get; set; }

        [StringLength(4000)]
        public string PhucLoi { get; set; }

        public bool? IsVisible { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
