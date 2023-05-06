namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_YeuCauCongViec_PhieuYeuCauTiepNhanDetail
    {
        public int ID { get; set; }

        public int? IDPhieuDetail { get; set; }

        public int? IDChucDanhDetail { get; set; }

        public int? IDNguoiNhan { get; set; }
    }
}
