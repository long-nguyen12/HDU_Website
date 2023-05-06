namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDen_Ver2_ButPheLichSu
    {
        public int ID { get; set; }

        public int IDVanBanDen { get; set; }

        public int? IDNguoiChuyenButPhe { get; set; }

        public DateTime? NgayChuyenButPhe { get; set; }

        public bool? IsDaButPhe { get; set; }

        public int? IDNguoiButPhe { get; set; }

        public DateTime? NgayButPhe { get; set; }

        public string NoiDungButPhe { get; set; }

        public DateTime? NgayXem { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
