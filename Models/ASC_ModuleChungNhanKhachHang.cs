namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASC_ModuleChungNhanKhachHang
    {
        public int ID { get; set; }

        public int? IDModule { get; set; }

        public int? LoaiChungNhan { get; set; }

        public int? IDNguoiDung { get; set; }

        public int? IDKhachHang { get; set; }
    }
}
