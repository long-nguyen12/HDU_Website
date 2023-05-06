namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_YeuCauCongViec_PhanQuyenXuLyTheoQuyTrinh
    {
        public int ID { get; set; }

        [StringLength(2000)]
        public string TenPhongBanThucHienQuyTrinh { get; set; }

        public int? IDNhanSuPhuTrach { get; set; }

        public int? IDLoaiPhuTrach { get; set; }

        public int? STTQuyTrinh { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
