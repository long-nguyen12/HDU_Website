namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ads_ScriptKey_Show
    {
        public int ID { get; set; }

        public int? IDScriptKey { get; set; }

        public int? IDKhachHang { get; set; }

        public int? IDPhanHe { get; set; }

        public int? IDUser { get; set; }

        public int? Show { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }
    }
}
