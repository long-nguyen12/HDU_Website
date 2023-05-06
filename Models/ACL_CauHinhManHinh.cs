namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACL_CauHinhManHinh
    {
        public int ID { get; set; }

        public int? IDManHinh { get; set; }

        [StringLength(200)]
        public string TenCauHinhManHinh { get; set; }
    }
}
