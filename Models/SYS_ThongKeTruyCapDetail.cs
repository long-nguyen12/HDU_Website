namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_ThongKeTruyCapDetail
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

        public DateTime? NgayTruyCap { get; set; }

        public DateTime? LanTruyCapGanNhat { get; set; }

        public int? SoLuotTruyCap { get; set; }

        public int? ForWeb { get; set; }
    }
}
