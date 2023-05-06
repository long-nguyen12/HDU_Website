namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_GiaoViecBaoCaoFileAttach
    {
        public int ID { get; set; }

        public int? IDBaoCao { get; set; }

        public int? IDFile { get; set; }

        public int? Loai { get; set; }
    }
}
