namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACL_DanhMucTinTucSinhVien
    {
        public int ID { get; set; }

        public int? IDDMTin { get; set; }

        public int? IDCoSo { get; set; }

        public int? IDKhoaHoc { get; set; }

        public int? IDHeDaoTao { get; set; }

        public int? IDLoaiHinhDT { get; set; }

        public int? IDKhoa { get; set; }

        public int? IDNganh { get; set; }
    }
}
