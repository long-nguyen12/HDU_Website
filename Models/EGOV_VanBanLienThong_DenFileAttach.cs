namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanLienThong_DenFileAttach
    {
        public int ID { get; set; }

        public int IDVBLT { get; set; }

        [StringLength(100)]
        public string ContentType { get; set; }

        [StringLength(100)]
        public string ContentId { get; set; }

        [StringLength(200)]
        public string AttachmentName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public string ContentTransferEncoded { get; set; }
    }
}
