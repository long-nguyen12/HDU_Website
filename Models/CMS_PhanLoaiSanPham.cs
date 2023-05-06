namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_PhanLoaiSanPham
    {
        public int ID { get; set; }

        public int? IDSanPham { get; set; }

        public int? IDDanhMuc { get; set; }

        public int? SoThuTu { get; set; }
    }
}
