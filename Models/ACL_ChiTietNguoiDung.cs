namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACL_ChiTietNguoiDung
    {
        public int ID { get; set; }

        public int? IDNguoiDung { get; set; }

        public int? IDQuocGia { get; set; }

        public int? IDDanToc { get; set; }

        public int? IDPhongBan { get; set; }

        public int? IDChucVu { get; set; }

        public int? IDHocHam { get; set; }

        public int? HocHamNamPhong { get; set; }

        public int? IDHocVi { get; set; }

        public int? HocViNamHoc { get; set; }

        [StringLength(200)]
        public string HocViNoiHoc { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        [StringLength(300)]
        public string HinhDaiDien { get; set; }

        [StringLength(50)]
        public string TaxMaCanBo { get; set; }

        public int? TaxIDCoQuanThue { get; set; }

        public int? TaxIDPhongDoi { get; set; }

        public int? TaxIDChucVu { get; set; }
    }
}
