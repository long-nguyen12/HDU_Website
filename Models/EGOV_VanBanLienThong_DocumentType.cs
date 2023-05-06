namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanLienThong_DocumentType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? LoaiCuaVanBan { get; set; }

        public int? IDLoai { get; set; }

        [StringLength(50)]
        public string TenLoai { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }
    }
}
