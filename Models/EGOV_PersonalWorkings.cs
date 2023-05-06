namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_PersonalWorkings
    {
        public int ID { get; set; }

        public int? WeekNumber { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? ForUserID { get; set; }

        public int? CreatedBy { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }
    }
}
