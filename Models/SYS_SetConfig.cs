namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_SetConfig
    {
        public int ID { get; set; }

        public int? IDConfig { get; set; }

        [StringLength(200)]
        public string KeyConfig { get; set; }

        public string ValueConfig { get; set; }

        public int ForWeb { get; set; }
    }
}
