namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACL_PhanQuyenSinhVienLienHe
    {
        public int ID { get; set; }

        public int IDNhomNguoiDung { get; set; }

        public int IDPhongBan { get; set; }

        public bool? IsChoPhep { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }
    }
}
