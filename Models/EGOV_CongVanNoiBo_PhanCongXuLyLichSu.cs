namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_CongVanNoiBo_PhanCongXuLyLichSu
    {
        public int ID { get; set; }

        public int? IDCongVan { get; set; }

        public int? Nguon { get; set; }

        public int? IDTrangThaiBaoCao { get; set; }

        public int? IDNguoiBaoCao { get; set; }

        public DateTime? NgayBaoCao { get; set; }

        public string NoiDungBaoCao { get; set; }

        public int? IDTrangThaiDanhGia { get; set; }

        public int? IDNguoiDanhGia { get; set; }

        public DateTime? NgayDanhGia { get; set; }

        public string NoiDungDanhGia { get; set; }

        public int? IDDonVi { get; set; }
    }
}
