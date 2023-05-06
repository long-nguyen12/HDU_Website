namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_ThongBaoViewed
    {
        public int ID { get; set; }

        public int? IDThongBao { get; set; }

        public int? IDNhomNguoiDung { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
