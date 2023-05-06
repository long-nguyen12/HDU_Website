namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DA_CongViec_LichSu
    {
        public int ID { get; set; }

        public int IDCongViec { get; set; }

        public DateTime Ngay { get; set; }

        public string GhiChu { get; set; }

        public int? IDTrangThai { get; set; }

        public int? IDTrangThaiNew { get; set; }

        public int? IDDoUuTien { get; set; }

        public int? IDDoUuTienNew { get; set; }

        public DateTime? BatDau { get; set; }

        public DateTime? BatDauNew { get; set; }

        public DateTime? HetHan { get; set; }

        public DateTime? HetHanNew { get; set; }

        public double? SoNgayCong { get; set; }

        public double? SoNgayCongNew { get; set; }

        public int? TienDoNew { get; set; }

        public int? TienDo { get; set; }

        public int? PhuTrachNew { get; set; }

        public int? PhuTrach { get; set; }

        public int? DinhKemDK { get; set; }

        public bool? DelYN { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
