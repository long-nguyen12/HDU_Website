namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_SoVanBan_PhanQuyenXuLyVanBan
    {
        public int ID { get; set; }

        public int? IDCoSo { get; set; }

        public int? IDDonVi { get; set; }

        public int? IDNhanSuPhuTrach { get; set; }

        public int? IDLoaiPhuTrach { get; set; }
    }
}
