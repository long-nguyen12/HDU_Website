namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanHanhChinh
    {
        public int ID { get; set; }

        public int? IDLoaiVanBan { get; set; }

        [StringLength(4000)]
        public string TenVanBan { get; set; }

        public int? IDNguoiSoan { get; set; }

        public int? IDPhongBanSoan { get; set; }

        public int? IDNguoiKyNhay { get; set; }

        public int? IDNguoiKy { get; set; }

        public DateTime? NgayNhan { get; set; }

        public DateTime? NgayHoanThanh { get; set; }

        public string NoiDungLoiVanBan { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
