namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TD_UngVien_FileAttach
    {
        public int ID { get; set; }

        public int? IDUngVien { get; set; }

        public int? IDFileDinhKem { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        [StringLength(100)]
        public string TenFileDinhKem { get; set; }

        [StringLength(20)]
        public string KieuFileDinhKem { get; set; }

        [StringLength(50)]
        public string CheckSum { get; set; }

        public int? KichThuoc { get; set; }
    }
}
