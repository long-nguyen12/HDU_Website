namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_TrinhKyDetail
    {
        public int ID { get; set; }

        public int? IDTrinhKy { get; set; }

        public int? IDQuyTrinh { get; set; }

        public DateTime? ThoiHanXuLy { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? IDChucDanh { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public int? IDTrangThaiDuyet { get; set; }

        public string GhiChuDuyet { get; set; }
    }
}
