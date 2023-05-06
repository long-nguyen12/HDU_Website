namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_SoVanBan_PhanCongPhuTrach
    {
        public int ID { get; set; }

        public int? IDSoVanBan { get; set; }

        public int? IDDonViPhuTrach { get; set; }

        public int? IDNhanSuPhuTrach { get; set; }
    }
}
