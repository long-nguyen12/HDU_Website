namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOB_ViecLam
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaCongViec { get; set; }

        [StringLength(1000)]
        public string TenCongViec { get; set; }

        public string MoTaCongViec { get; set; }

        public string QuyenLoiDuocHuong { get; set; }

        public string YeuCauCongViec { get; set; }

        public string YeuCauHoSo { get; set; }

        public int? SoLuongTuyen { get; set; }

        public bool? YeuCauGioiTinh { get; set; }

        public DateTime? HanNopHoSo { get; set; }

        public int? IDCapBac { get; set; }

        public int? IDLoaiHinhCV { get; set; }

        public int? IDMucLuong { get; set; }

        public int? IDKinhNghiem { get; set; }

        public int? IDBangCap { get; set; }

        public int? IDNgonNgu { get; set; }

        [StringLength(200)]
        public string NguoiLienHe { get; set; }

        [StringLength(200)]
        public string EmailLienHe { get; set; }

        [StringLength(200)]
        public string SoDienThoaiLienHe { get; set; }

        public int? SoThuTu { get; set; }

        public int? IDCongTy { get; set; }

        public int? ForWeb { get; set; }

        public bool? IsViecMoi { get; set; }

        public bool? IsTuyenGap { get; set; }

        public bool? IsHapDan { get; set; }

        public bool? IsTop { get; set; }

        public bool? IsHienThi { get; set; }

        public bool? IsDuyet { get; set; }

        public int? IDNguoiDuyet { get; set; }

        public DateTime? NgayDuyet { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
