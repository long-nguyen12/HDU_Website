namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MES_Messages
    {
        public long ID { get; set; }

        public int? FromUser { get; set; }

        public int? ToUser { get; set; }

        public int? ToGroup { get; set; }

        public string Message { get; set; }

        public DateTime? NgayTao { get; set; }

        public bool? IsDelete { get; set; }
    }
}
