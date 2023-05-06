namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanLienThong_DiTrangThai
    {
        public int ID { get; set; }

        public int? IDVBLT_Di { get; set; }

        [StringLength(200)]
        public string DocId { get; set; }

        [StringLength(20)]
        public string ResponseForOrganId { get; set; }

        [StringLength(50)]
        public string ResponseForCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ResponseForPromulgationDate { get; set; }

        [StringLength(200)]
        public string ResponseForDocumentId { get; set; }

        [StringLength(200)]
        public string StaffInfoDepartment { get; set; }

        [StringLength(100)]
        public string StaffInfoStaff { get; set; }

        [StringLength(50)]
        public string StaffInfoMobile { get; set; }

        [StringLength(5)]
        public string StatusCode { get; set; }

        public int? StatusNumber { get; set; }

        [StringLength(200)]
        public string StatusName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? Timestamp { get; set; }

        [StringLength(20)]
        public string FromOrganId { get; set; }

        [StringLength(200)]
        public string FromOrganizationInCharge { get; set; }

        [StringLength(200)]
        public string FromOrganName { get; set; }

        [StringLength(250)]
        public string FromOrganAdd { get; set; }

        [StringLength(100)]
        public string FromEmail { get; set; }

        [StringLength(50)]
        public string FromTelephone { get; set; }

        [StringLength(50)]
        public string FromFax { get; set; }

        [StringLength(100)]
        public string FromWebsite { get; set; }
    }
}
