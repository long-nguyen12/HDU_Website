namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDen_Ver2_ButPheLichSuFileAttach
    {
        public int ID { get; set; }

        public int? IDButPheLichSu { get; set; }

        public int? IDFile { get; set; }
    }
}
