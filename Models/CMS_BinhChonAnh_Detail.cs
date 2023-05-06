namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_BinhChonAnh_Detail
    {
        public int ID { get; set; }

        public int? ID_BinhChonAnh { get; set; }

        [StringLength(50)]
        public string IPAdress { get; set; }

        public DateTime? ThoiGianBinhChon { get; set; }

        [StringLength(50)]
        public string OsName { get; set; }

        [StringLength(50)]
        public string OsVersion { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(250)]
        public string EngineName { get; set; }

        [StringLength(50)]
        public string EngineVersion { get; set; }

        [StringLength(250)]
        public string BrowserName { get; set; }

        [StringLength(50)]
        public string BrowserVersion { get; set; }
    }
}
