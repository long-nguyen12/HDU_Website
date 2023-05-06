namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_MailNguoiNhan
    {
        public int ID { get; set; }

        public int? IDMail { get; set; }

        public int? IDNguoiNhan { get; set; }

        public bool IsCC { get; set; }

        public int Mark { get; set; }

        public DateTime? NgayXem { get; set; }

        public int TrangThaiNhan { get; set; }

        public int? Flag { get; set; }

        public int? TrangThaiXemMail { get; set; }
    }
}
