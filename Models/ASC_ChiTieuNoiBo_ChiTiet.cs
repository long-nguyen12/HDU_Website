namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASC_ChiTieuNoiBo_ChiTiet
    {
        public int ID { get; set; }

        public int? IDChiTieuNoiBo { get; set; }

        public string MoTa { get; set; }

        public decimal? SoTien { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public DateTime? NgayDelete { get; set; }

        public bool? IsDelete { get; set; }
    }
}
