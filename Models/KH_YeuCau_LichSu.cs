namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KH_YeuCau_LichSu
    {
        public int ID { get; set; }

        public int IDYeuCau { get; set; }

        public DateTime Ngay { get; set; }

        public string GhiChu { get; set; }

        public int? IDTrangThai { get; set; }

        public int? IDTrangThaiNew { get; set; }

        public int? IDDoUuTien { get; set; }

        public int? IDDoUuTienNew { get; set; }

        public int? IDDoNghiemTrong { get; set; }

        public int? IDDoNghiemTrongNew { get; set; }

        public int? IDLoai { get; set; }

        public int? IDLoaiNew { get; set; }

        public int? IDPhongBanXuLy { get; set; }

        public int? IDPhongBanXuLyNew { get; set; }

        public bool? DelYN { get; set; }

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
