namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_ChuKyDienTu
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string SerialNumber { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnh { get; set; }

        public int? IdFile { get; set; }
    }
}
