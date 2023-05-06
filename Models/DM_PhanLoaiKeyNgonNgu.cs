namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_PhanLoaiKeyNgonNgu
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string Ma { get; set; }

        [StringLength(200)]
        public string Ten { get; set; }

        [StringLength(20)]
        public string Tag { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? NguoiCapNhat { get; set; }
    }
}
