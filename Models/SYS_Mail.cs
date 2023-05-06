namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Mail
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string MailAddress { get; set; }

        [StringLength(200)]
        public string MailPassword { get; set; }

        [StringLength(200)]
        public string SMTPHost { get; set; }

        public int? Port { get; set; }

        public bool? EnableSSL { get; set; }

        public bool? IsSuDung { get; set; }

        public int? IDNhomEmail { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
