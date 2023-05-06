namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_LoaiHopDongQuyetDinh
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaLoai { get; set; }

        [StringLength(200)]
        public string TenLoai { get; set; }

        [StringLength(20)]
        public string PreFix { get; set; }

        [StringLength(20)]
        public string SufFix { get; set; }
    }
}
