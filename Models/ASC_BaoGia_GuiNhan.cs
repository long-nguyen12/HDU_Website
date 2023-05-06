namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASC_BaoGia_GuiNhan
    {
        public int ID { get; set; }

        public int IDBaoGia { get; set; }

        public int? IDNguoiGui { get; set; }

        [StringLength(200)]
        public string NguoiGui { get; set; }

        public DateTime? NgayGui { get; set; }

        [StringLength(200)]
        public string NguoiNhan { get; set; }

        [StringLength(50)]
        public string EmailNguoiNhan { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? IDTrangThai { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
