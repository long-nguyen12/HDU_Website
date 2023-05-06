namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DA_CongViecViewed
    {
        public int ID { get; set; }

        public int? IDCongViec { get; set; }

        public int? IDNhomNguoiDung { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
