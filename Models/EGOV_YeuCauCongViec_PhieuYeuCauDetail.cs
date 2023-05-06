namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_YeuCauCongViec_PhieuYeuCauDetail
    {
        public int ID { get; set; }

        public int? IDPhieuYeuCau { get; set; }

        public int? IDLoaiDoiTuong { get; set; }

        public DateTime? ThoiHanXuLy { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? IDTrangThaiDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public int? IDChiTietTiepNhan { get; set; }

        public int? IDPhongBanNhan { get; set; }

        public string GhiChuDuyet { get; set; }

        public bool? IsDuyet { get; set; }
    }
}
