namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanDen_Ver2_PhanCongXuLyLichSu
    {
        public int ID { get; set; }

        public int IDPhanCongXuLy { get; set; }

        public int? IDTrangThaiCu { get; set; }

        public int? IDTrangThaiMoi { get; set; }

        public int? IDNguoiBaoCao { get; set; }

        public DateTime? NgayBaoCao { get; set; }

        public string NoiDungBaoCao { get; set; }

        public int? IDNguoiPhanHoi { get; set; }

        public DateTime? NgayPhanHoi { get; set; }

        public string NoiDungPhanHoi { get; set; }

        public DateTime? NgayXemBaoCao { get; set; }

        public DateTime? NgayXemPhanHoi { get; set; }
    }
}
