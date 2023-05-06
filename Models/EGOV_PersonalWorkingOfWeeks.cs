namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_PersonalWorkingOfWeeks
    {
        public int ID { get; set; }

        public int? PersonalWorkingID { get; set; }

        public int? DayOfWeekID { get; set; }

        [StringLength(4000)]
        public string Content { get; set; }

        public string Chieu { get; set; }

        public string Toi { get; set; }
    }
}
