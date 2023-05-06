namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_GiaoViecBaoCao
    {
        public int ID { get; set; }

        public int? IDGiaoViec { get; set; }

        public string NoiDung { get; set; }

        public int? IDNguoiBaoCao { get; set; }

        public DateTime? NgayBaoCao { get; set; }

        public int? TrangThaiXuLy { get; set; }

        public int? TrangThaiDanhGia { get; set; }

        [StringLength(4000)]
        public string NoiDungDanhGia { get; set; }

        public int? IDNguoiDanhGia { get; set; }

        public DateTime? NgayDanhGia { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? IDNguoiThamChieu { get; set; }
    }
}
