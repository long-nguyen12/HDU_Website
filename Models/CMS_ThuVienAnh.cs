namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_ThuVienAnh
    {
        public long ID { get; set; }

        public int IDAlbum { get; set; }

        [StringLength(300)]
        public string TenAnh { get; set; }

        public int? IDFile { get; set; }
    }
}
