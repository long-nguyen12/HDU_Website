namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOB_KinhNghiemUngVien
    {
        public int ID { get; set; }

        public int? IDUngVien { get; set; }

        [StringLength(1000)]
        public string TaiCongTy { get; set; }

        [StringLength(1000)]
        public string ChucDanhViTri { get; set; }

        public string MoTaCongViec { get; set; }

        public DateTime? BatDau { get; set; }

        public DateTime? KetThuc { get; set; }

        public bool? IsCongViecHienTai { get; set; }

        public int? SoThuTu { get; set; }

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
