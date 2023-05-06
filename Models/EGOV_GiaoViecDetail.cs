namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_GiaoViecDetail
    {
        public int ID { get; set; }

        public int? IDGiaoViec { get; set; }

        public int? IDNguoiThucHien { get; set; }

        public bool? HoanThanh { get; set; }

        public DateTime? NgayXem { get; set; }

        public int? IDTrangThaiXuLy { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiThamChieu { get; set; }

        public string NoiDungChiDao { get; set; }
    }
}
