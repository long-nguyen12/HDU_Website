namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanLienThong_DiTo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDVBLT_Di { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ToIDCoQuan { get; set; }

        [Required]
        [StringLength(50)]
        public string ToOrganId { get; set; }

        [StringLength(200)]
        public string ToOrganizationInCharge { get; set; }

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
