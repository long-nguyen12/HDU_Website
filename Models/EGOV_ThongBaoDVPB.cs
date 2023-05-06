namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_ThongBaoDVPB
    {
        public int ID { get; set; }

        public int? IDThongBao { get; set; }

        public int? IDDonVi { get; set; }

        public int? IDPhongBan { get; set; }

        public int? IDTruong { get; set; }

        public int? IDNhomLienHe { get; set; }
    }
}
