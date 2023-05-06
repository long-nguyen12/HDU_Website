namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SV_LienHeReply
    {
        public int ID { get; set; }

        public int IDLienHe { get; set; }

        [StringLength(50)]
        public string MaSinhVien { get; set; }

        public string NoiDung { get; set; }

        public bool? IsHienThi { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDPhongBan { get; set; }
    }
}
