namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ELN_ACL_LoaiTaiLieu
    {
        public int ID { get; set; }

        public int? IDLoaiTaiLieu { get; set; }

        public int? IDNhomNguoiDung { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
