namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DA_DuAn
    {
        public int ID { get; set; }

        public int? IDDuAnThamChieu { get; set; }

        public int? IDThamChieu { get; set; }

        public string TenDuAn { get; set; }

        public string MoTa { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        public int? IDDuAnNew { get; set; }

        [StringLength(50)]
        public string MaDuAn { get; set; }

        public int? IDKeHoach { get; set; }

        public decimal? TongTien { get; set; }

        public int? IDChuyenNganh { get; set; }

        public int? IDNguoiPhuTrach { get; set; }

        public int? IDNguoiPhoiHop { get; set; }

        public bool? Del_YN { get; set; }

        public int? IDPhongBan { get; set; }

        public int? IDBuoc { get; set; }

        public int? IDNhomDuAn { get; set; }

        public int? IDTinhThanh { get; set; }

        [StringLength(1000)]
        public string ChuDauTu { get; set; }

        [Column(TypeName = "ntext")]
        public string DonViThuHuong { get; set; }

        public int? SoTien { get; set; }

        public int? ChiPhiPhatSinh { get; set; }

        [StringLength(1000)]
        public string LoaiSanPham { get; set; }

        public int? IDSoBanNganh { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        public bool? IsDefault { get; set; }

        public int? SoThuTu { get; set; }

        public bool? IsHoanThanh { get; set; }
    }
}
