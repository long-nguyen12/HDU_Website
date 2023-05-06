namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_TinTuc_CauHinh
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string TenCauHinh { get; set; }

        public int? IDCoSo { get; set; }

        public int? IDKhoaHoc { get; set; }

        public int? IDBacDaoTao { get; set; }

        public int? IDLoaiHinhDaoTao { get; set; }

        public int? IDKhoa { get; set; }

        public int? IDNganh { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public bool? IsDelete { get; set; }

        public int? ForWeb { get; set; }
    }
}
