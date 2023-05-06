namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanLienThong_DenResponseFor
    {
        public int ID { get; set; }

        public int IDVBLT { get; set; }

        [StringLength(200)]
        public string DocumentId { get; set; }

        public DateTime? PromulgationDate { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string OrganId { get; set; }
    }
}
