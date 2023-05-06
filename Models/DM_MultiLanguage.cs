namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_MultiLanguage
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string KeyName { get; set; }

        [StringLength(20)]
        public string PhanLoai { get; set; }

        public bool? IsDelete { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? NguoiCapNhat { get; set; }

        public string GiaTriDefault { get; set; }
    }
}
