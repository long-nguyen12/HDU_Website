namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_TruongImages
    {
        public int ID { get; set; }

        public int? IDTruong { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public int? LoaiImage { get; set; }

        [StringLength(500)]
        public string LienKet { get; set; }

        [StringLength(100)]
        public string CssClass { get; set; }
    }
}
