namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_SharePersonalWorkings
    {
        public int ID { get; set; }

        public int? FromUserID { get; set; }

        public int? ShareUserID { get; set; }
    }
}
