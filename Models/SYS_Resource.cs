namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Resource
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string KeyResource { get; set; }

        public string ValueResource { get; set; }
    }
}
