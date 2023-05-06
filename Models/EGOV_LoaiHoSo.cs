namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_LoaiHoSo
    {
        public int ID { get; set; }

        public int? IDParent { get; set; }

        [StringLength(500)]
        public string TenLoaiHoSo { get; set; }

        public string GhiChu { get; set; }

        public int? SoThuThu { get; set; }

        public bool? IsHienThi { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? KichThuocFile { get; set; }
    }
}
