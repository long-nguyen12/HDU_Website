namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NOF_Devices
    {
        public int ID { get; set; }

        public int? IDUser { get; set; }

        public bool? IsMember { get; set; }

        [StringLength(200)]
        public string OSID { get; set; }

        [StringLength(200)]
        public string DeviceInfo { get; set; }

        public int? LoaiThietBi { get; set; }

        public bool? Subscribed { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }
    }
}
