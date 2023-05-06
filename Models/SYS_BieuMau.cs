namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_BieuMau
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBieuMau { get; set; }

        [Required]
        [StringLength(200)]
        public string TenBieuMau { get; set; }

        [StringLength(200)]
        public string TenFile { get; set; }

        public byte[] NoiDung { get; set; }

        [StringLength(50)]
        public string LoaiFile { get; set; }

        [StringLength(4000)]
        public string GhiChu { get; set; }

        [StringLength(50)]
        public string CheckSum { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }
    }
}
