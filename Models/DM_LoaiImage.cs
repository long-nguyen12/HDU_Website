namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LoaiImage
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string TenLoaiImage { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }
    }
}
