namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_HopDongQuyetDinh
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string SoHDQD { get; set; }

        public DateTime? NgayHDQD { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        public int? IDNguoiKy { get; set; }

        [StringLength(50)]
        public string NguoiKy { get; set; }

        public int? Loai { get; set; }

        public int? IDNguoiTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public DateTime? NgayNhap { get; set; }

        public int? Nam { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public bool? IsNhanBanCung { get; set; }

        public int? ForWeb { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
