namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_ThanhVien_TheoDoi
    {
        public int ID { get; set; }

        public int? IDThanhVien { get; set; }

        public int? IDLinhVuc { get; set; }

        public int? IDNganh { get; set; }

        public int? IDTruong { get; set; }
    }
}
