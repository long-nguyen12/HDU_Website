namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_ThanhVien_LichSuThongBao
    {
        public int ID { get; set; }

        public int? IDThanhVien { get; set; }

        public string NoiDungThongBao { get; set; }

        public DateTime? NgayNhan { get; set; }

        public bool? IsDaXem { get; set; }

        public DateTime? NgayXem { get; set; }

        public int? LoaiThongBao { get; set; }

        public int? IDThamChieu { get; set; }
    }
}
