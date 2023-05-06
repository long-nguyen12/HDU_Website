namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACL_Action
    {
        public int ID { get; set; }

        public int IDManHinh { get; set; }

        [StringLength(200)]
        public string TenAction { get; set; }

        [StringLength(200)]
        public string TenController { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public int? Loai { get; set; }

        [StringLength(200)]
        public string Ten { get; set; }
    }
}
