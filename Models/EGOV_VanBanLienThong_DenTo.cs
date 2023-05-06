namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanLienThong_DenTo
    {
        public int ID { get; set; }

        public int IDVBLT { get; set; }

        [Required]
        [StringLength(50)]
        public string ToOrganId { get; set; }

        [StringLength(200)]
        public string ToOrganizationInCharge { get; set; }

        [Required]
        [StringLength(200)]
        public string ToOrganName { get; set; }

        [StringLength(250)]
        public string ToOrganAdd { get; set; }

        [StringLength(100)]
        public string ToEmail { get; set; }

        [StringLength(50)]
        public string ToTelephone { get; set; }

        [StringLength(50)]
        public string ToFax { get; set; }

        [StringLength(100)]
        public string ToWebsite { get; set; }
    }
}
