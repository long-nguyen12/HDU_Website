namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_ThanhVien_DangKyTheoDoi
    {
        public int ID { get; set; }

        public int? IDThanhVien { get; set; }

        public int? IDDoiTuongTag { get; set; }

        public byte? LoaiDoiTuongTag { get; set; }
    }
}
