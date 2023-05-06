namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_CaiDatCauHinh
    {
        public int ID { get; set; }

        public int? IDCauHinh { get; set; }

        [StringLength(50)]
        public string KeyCauHinh { get; set; }

        public string ValueCauHinh { get; set; }

        public int? ForWeb { get; set; }
    }
}
