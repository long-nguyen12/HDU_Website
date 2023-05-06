namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_YeuCauCongViec_CauHinhChucDanhDetail
    {
        public int ID { get; set; }

        public int? IDChucDanh { get; set; }

        public int? IDPhongBan { get; set; }

        public int? IDNhanSu { get; set; }
    }
}
