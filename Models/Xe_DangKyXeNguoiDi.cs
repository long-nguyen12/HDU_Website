namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Xe_DangKyXeNguoiDi
    {
        public int ID { get; set; }

        public int? IDDangKyXe { get; set; }

        public int? IDNguoiDi { get; set; }

        public DateTime? NgayXem { get; set; }
    }
}
