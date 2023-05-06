namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_NganhTruongImages
    {
        public int ID { get; set; }

        public int? IDNganhTruong { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        public int? IDLoaiImage { get; set; }

        [StringLength(500)]
        public string LienKet { get; set; }

        [StringLength(100)]
        public string CssClass { get; set; }
    }
}
