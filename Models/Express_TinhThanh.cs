namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Express_TinhThanh
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string MaTinh { get; set; }

        [StringLength(50)]
        public string TenTinh { get; set; }

        public int? CuLy { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? SoThuTu { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public int? IDQuocGia { get; set; }
    }
}
