namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanLienThong_Config
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(200)]
        public string SystemId { get; set; }

        [StringLength(200)]
        public string SecretKey { get; set; }

        [StringLength(200)]
        public string Endpoint { get; set; }

        [StringLength(50)]
        public string OrganId { get; set; }

        [StringLength(200)]
        public string OrganizationInCharge { get; set; }

        [StringLength(200)]
        public string OrganName { get; set; }

        [StringLength(250)]
        public string OrganAdd { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(100)]
        public string Website { get; set; }
    }
}
