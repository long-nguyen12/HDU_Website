using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HDU_Website.Models
{
    public partial class DBConnection : DbContext
    {
        public DBConnection()
            : base("name=DBConnection")
        {
        }

        public virtual DbSet<ACL_Action> ACL_Action { get; set; }
        public virtual DbSet<ACL_CauHinhManHinh> ACL_CauHinhManHinh { get; set; }
        public virtual DbSet<ACL_ChiTietNguoiDung> ACL_ChiTietNguoiDung { get; set; }
        public virtual DbSet<ACL_ChonNhanSu> ACL_ChonNhanSu { get; set; }
        public virtual DbSet<ACL_DanhMucDaoTao> ACL_DanhMucDaoTao { get; set; }
        public virtual DbSet<ACL_DanhMucGioiThieu> ACL_DanhMucGioiThieu { get; set; }
        public virtual DbSet<ACL_DanhMucTinTuc> ACL_DanhMucTinTuc { get; set; }
        public virtual DbSet<ACL_DanhMucTinTucSinhVien> ACL_DanhMucTinTucSinhVien { get; set; }
        public virtual DbSet<ACL_DanhMucTraCuuVanBan> ACL_DanhMucTraCuuVanBan { get; set; }
        public virtual DbSet<ACL_HoSo> ACL_HoSo { get; set; }
        public virtual DbSet<ACL_LoaiHoSo> ACL_LoaiHoSo { get; set; }
        public virtual DbSet<ACL_ManHinh> ACL_ManHinh { get; set; }
        public virtual DbSet<ACL_NhomNguoiDung> ACL_NhomNguoiDung { get; set; }
        public virtual DbSet<ACL_PhanQuyen> ACL_PhanQuyen { get; set; }
        public virtual DbSet<ACL_PhanQuyenNhanSuPhongBan> ACL_PhanQuyenNhanSuPhongBan { get; set; }
        public virtual DbSet<ACL_PhanQuyenNhanSuPhongXuong> ACL_PhanQuyenNhanSuPhongXuong { get; set; }
        public virtual DbSet<ACL_PhanQuyenPhongSo> ACL_PhanQuyenPhongSo { get; set; }
        public virtual DbSet<ACL_PhanQuyenSinhVienLienHe> ACL_PhanQuyenSinhVienLienHe { get; set; }
        public virtual DbSet<ACL_PhanQuyenWebsite> ACL_PhanQuyenWebsite { get; set; }
        public virtual DbSet<ACL_TaiKhoan> ACL_TaiKhoan { get; set; }
        public virtual DbSet<Ads_DonViQuangCao> Ads_DonViQuangCao { get; set; }
        public virtual DbSet<Ads_LinhVuc> Ads_LinhVuc { get; set; }
        public virtual DbSet<Ads_LinhVuc_QuangCao> Ads_LinhVuc_QuangCao { get; set; }
        public virtual DbSet<Ads_Promotion_Collection> Ads_Promotion_Collection { get; set; }
        public virtual DbSet<Ads_Promotion_Diary> Ads_Promotion_Diary { get; set; }
        public virtual DbSet<Ads_PromotionCode_Received> Ads_PromotionCode_Received { get; set; }
        public virtual DbSet<Ads_QuangCao> Ads_QuangCao { get; set; }
        public virtual DbSet<Ads_QuangCao_Click> Ads_QuangCao_Click { get; set; }
        public virtual DbSet<Ads_QuangCao_KhachHang> Ads_QuangCao_KhachHang { get; set; }
        public virtual DbSet<Ads_ScriptKey> Ads_ScriptKey { get; set; }
        public virtual DbSet<Ads_ScriptKey_Show> Ads_ScriptKey_Show { get; set; }
        public virtual DbSet<Ads_ThongKeClick> Ads_ThongKeClick { get; set; }
        public virtual DbSet<Ads_ViTri> Ads_ViTri { get; set; }
        public virtual DbSet<Ads_ViTri_QuangCao> Ads_ViTri_QuangCao { get; set; }
        public virtual DbSet<APP_Notify> APP_Notify { get; set; }
        public virtual DbSet<ASC_BaoGia> ASC_BaoGia { get; set; }
        public virtual DbSet<ASC_BaoGia_GuiNhan> ASC_BaoGia_GuiNhan { get; set; }
        public virtual DbSet<ASC_BaoGia_GuiNhanFileAttach> ASC_BaoGia_GuiNhanFileAttach { get; set; }
        public virtual DbSet<ASC_BaoGiaFileAttach> ASC_BaoGiaFileAttach { get; set; }
        public virtual DbSet<ASC_ChiTieuNoiBo> ASC_ChiTieuNoiBo { get; set; }
        public virtual DbSet<ASC_ChiTieuNoiBo_ChiTiet> ASC_ChiTieuNoiBo_ChiTiet { get; set; }
        public virtual DbSet<ASC_ChiTieuNoiBo_DaXem> ASC_ChiTieuNoiBo_DaXem { get; set; }
        public virtual DbSet<ASC_ChiTieuNoiBo_LichSu> ASC_ChiTieuNoiBo_LichSu { get; set; }
        public virtual DbSet<ASC_ChiTieuNoiBoFileAttach> ASC_ChiTieuNoiBoFileAttach { get; set; }
        public virtual DbSet<ASC_ChiTieuNoiBoNguoiThamGia> ASC_ChiTieuNoiBoNguoiThamGia { get; set; }
        public virtual DbSet<ASC_DatVe> ASC_DatVe { get; set; }
        public virtual DbSet<ASC_DatVe_DaXem> ASC_DatVe_DaXem { get; set; }
        public virtual DbSet<ASC_DatVe_LichSu> ASC_DatVe_LichSu { get; set; }
        public virtual DbSet<ASC_DatVe_LichSuFileAttach> ASC_DatVe_LichSuFileAttach { get; set; }
        public virtual DbSet<ASC_DatVeFileAttach> ASC_DatVeFileAttach { get; set; }
        public virtual DbSet<ASC_DatVeNguoiDi> ASC_DatVeNguoiDi { get; set; }
        public virtual DbSet<ASC_HopDong> ASC_HopDong { get; set; }
        public virtual DbSet<ASC_HopDong_LichSu> ASC_HopDong_LichSu { get; set; }
        public virtual DbSet<ASC_HopDong_LoaiHD> ASC_HopDong_LoaiHD { get; set; }
        public virtual DbSet<ASC_HopDong_TrangThai> ASC_HopDong_TrangThai { get; set; }
        public virtual DbSet<ASC_HopDongFileAttach> ASC_HopDongFileAttach { get; set; }
        public virtual DbSet<ASC_HopDongGiaiDoan> ASC_HopDongGiaiDoan { get; set; }
        public virtual DbSet<ASC_HopDongGiaiDoan_TrangThai> ASC_HopDongGiaiDoan_TrangThai { get; set; }
        public virtual DbSet<ASC_HopDongGiaiDoanFileAttach> ASC_HopDongGiaiDoanFileAttach { get; set; }
        public virtual DbSet<ASC_HopDongHoSoFileAttach> ASC_HopDongHoSoFileAttach { get; set; }
        public virtual DbSet<ASC_HopDongHSNghiemThuFileAttach> ASC_HopDongHSNghiemThuFileAttach { get; set; }
        public virtual DbSet<ASC_Module> ASC_Module { get; set; }
        public virtual DbSet<ASC_ModuleChungNhan> ASC_ModuleChungNhan { get; set; }
        public virtual DbSet<ASC_ModuleChungNhanKhachHang> ASC_ModuleChungNhanKhachHang { get; set; }
        public virtual DbSet<ASC_StickyNotes> ASC_StickyNotes { get; set; }
        public virtual DbSet<ASC_TamUng> ASC_TamUng { get; set; }
        public virtual DbSet<ASC_TamUng_ChiTiet> ASC_TamUng_ChiTiet { get; set; }
        public virtual DbSet<ASC_TamUng_DaXem> ASC_TamUng_DaXem { get; set; }
        public virtual DbSet<ASC_TamUng_LichSu> ASC_TamUng_LichSu { get; set; }
        public virtual DbSet<ASC_TamUngFileAttach> ASC_TamUngFileAttach { get; set; }
        public virtual DbSet<ASC_TamUngFileAttachKeHoachCongTac> ASC_TamUngFileAttachKeHoachCongTac { get; set; }
        public virtual DbSet<ASC_TamUngNguoiThamGia> ASC_TamUngNguoiThamGia { get; set; }
        public virtual DbSet<CMS_AlbumAnh> CMS_AlbumAnh { get; set; }
        public virtual DbSet<CMS_AlbumAnhXoay> CMS_AlbumAnhXoay { get; set; }
        public virtual DbSet<CMS_AnhXoay> CMS_AnhXoay { get; set; }
        public virtual DbSet<CMS_BaiViet> CMS_BaiViet { get; set; }
        public virtual DbSet<CMS_BaiVietFileAttach> CMS_BaiVietFileAttach { get; set; }
        public virtual DbSet<CMS_BinhChonAnh> CMS_BinhChonAnh { get; set; }
        public virtual DbSet<CMS_BinhChonAnh_Detail> CMS_BinhChonAnh_Detail { get; set; }
        public virtual DbSet<CMS_ChiDaoDieuHanh> CMS_ChiDaoDieuHanh { get; set; }
        public virtual DbSet<CMS_ChiDaoDieuHanhFileAttach> CMS_ChiDaoDieuHanhFileAttach { get; set; }
        public virtual DbSet<CMS_DangKy> CMS_DangKy { get; set; }
        public virtual DbSet<CMS_DaoTao> CMS_DaoTao { get; set; }
        public virtual DbSet<CMS_DaoTaoFileAttach> CMS_DaoTaoFileAttach { get; set; }
        public virtual DbSet<CMS_DiaDiemThamQuan> CMS_DiaDiemThamQuan { get; set; }
        public virtual DbSet<CMS_DiaDiemThamQuanFileAttach> CMS_DiaDiemThamQuanFileAttach { get; set; }
        public virtual DbSet<CMS_DoanhNghiep> CMS_DoanhNghiep { get; set; }
        public virtual DbSet<CMS_DoanhNghiepFileAttach> CMS_DoanhNghiepFileAttach { get; set; }
        public virtual DbSet<CMS_DoiSongSinhVien> CMS_DoiSongSinhVien { get; set; }
        public virtual DbSet<CMS_DoiSongSinhVienFileAttach> CMS_DoiSongSinhVienFileAttach { get; set; }
        public virtual DbSet<CMS_DuAn> CMS_DuAn { get; set; }
        public virtual DbSet<CMS_DuAnHangMucDauTu> CMS_DuAnHangMucDauTu { get; set; }
        public virtual DbSet<CMS_DuAnHangMucDauTuFileAttach> CMS_DuAnHangMucDauTuFileAttach { get; set; }
        public virtual DbSet<CMS_GioiThieu> CMS_GioiThieu { get; set; }
        public virtual DbSet<CMS_GioiThieuFileAttach> CMS_GioiThieuFileAttach { get; set; }
        public virtual DbSet<CMS_HoiDongNhanDan> CMS_HoiDongNhanDan { get; set; }
        public virtual DbSet<CMS_HoiDongNhanDanFileAttach> CMS_HoiDongNhanDanFileAttach { get; set; }
        public virtual DbSet<CMS_HoSo> CMS_HoSo { get; set; }
        public virtual DbSet<CMS_HoSoFileAttach> CMS_HoSoFileAttach { get; set; }
        public virtual DbSet<CMS_KeHoachLichCongTac> CMS_KeHoachLichCongTac { get; set; }
        public virtual DbSet<CMS_KeHoachLichCongTacFileAttach> CMS_KeHoachLichCongTacFileAttach { get; set; }
        public virtual DbSet<CMS_LienHe> CMS_LienHe { get; set; }
        public virtual DbSet<CMS_LoaiAnh> CMS_LoaiAnh { get; set; }
        public virtual DbSet<CMS_LoaiHoSo> CMS_LoaiHoSo { get; set; }
        public virtual DbSet<CMS_LoaiSlide> CMS_LoaiSlide { get; set; }
        public virtual DbSet<CMS_LoaiVideo> CMS_LoaiVideo { get; set; }
        public virtual DbSet<CMS_Menu> CMS_Menu { get; set; }
        public virtual DbSet<CMS_NganhNgheTruyenThong> CMS_NganhNgheTruyenThong { get; set; }
        public virtual DbSet<CMS_NganhNgheTruyenThongFileAttach> CMS_NganhNgheTruyenThongFileAttach { get; set; }
        public virtual DbSet<CMS_NhomMenu> CMS_NhomMenu { get; set; }
        public virtual DbSet<CMS_NhomSoDoToChuc> CMS_NhomSoDoToChuc { get; set; }
        public virtual DbSet<CMS_PhanLoaiSanPham> CMS_PhanLoaiSanPham { get; set; }
        public virtual DbSet<CMS_QuyHoachChienLuocKeHoach> CMS_QuyHoachChienLuocKeHoach { get; set; }
        public virtual DbSet<CMS_QuyHoachChienLuocKeHoachFileAttach> CMS_QuyHoachChienLuocKeHoachFileAttach { get; set; }
        public virtual DbSet<CMS_Router> CMS_Router { get; set; }
        public virtual DbSet<CMS_SanPham> CMS_SanPham { get; set; }
        public virtual DbSet<CMS_SlideShow> CMS_SlideShow { get; set; }
        public virtual DbSet<CMS_SoDoToChuc> CMS_SoDoToChuc { get; set; }
        public virtual DbSet<CMS_SoDoToChucChiTiet> CMS_SoDoToChucChiTiet { get; set; }
        public virtual DbSet<CMS_ThanhVien> CMS_ThanhVien { get; set; }
        public virtual DbSet<CMS_ThanhVien_DangKyTheoDoi> CMS_ThanhVien_DangKyTheoDoi { get; set; }
        public virtual DbSet<CMS_ThanhVien_DangKyTuVan> CMS_ThanhVien_DangKyTuVan { get; set; }
        public virtual DbSet<CMS_ThanhVien_LichSuDangKyTuVan> CMS_ThanhVien_LichSuDangKyTuVan { get; set; }
        public virtual DbSet<CMS_ThanhVien_LichSuThongBao> CMS_ThanhVien_LichSuThongBao { get; set; }
        public virtual DbSet<CMS_ThanhVien_TheoDoi> CMS_ThanhVien_TheoDoi { get; set; }
        public virtual DbSet<CMS_ThanhVienCamNhan> CMS_ThanhVienCamNhan { get; set; }
        public virtual DbSet<CMS_ThongKeBaoCao> CMS_ThongKeBaoCao { get; set; }
        public virtual DbSet<CMS_ThongKeBaoCaoFileAttach> CMS_ThongKeBaoCaoFileAttach { get; set; }
        public virtual DbSet<CMS_ThuVienAnh> CMS_ThuVienAnh { get; set; }
        public virtual DbSet<CMS_TinTuc> CMS_TinTuc { get; set; }
        public virtual DbSet<CMS_TinTuc_Tag> CMS_TinTuc_Tag { get; set; }
        public virtual DbSet<CMS_TinTuc_Viewed> CMS_TinTuc_Viewed { get; set; }
        public virtual DbSet<CMS_TinTucBinhLuan> CMS_TinTucBinhLuan { get; set; }
        public virtual DbSet<CMS_TinTucFileAttach> CMS_TinTucFileAttach { get; set; }
        public virtual DbSet<CMS_TraCuuVanBan> CMS_TraCuuVanBan { get; set; }
        public virtual DbSet<CMS_TraCuuVanBanFileAttach> CMS_TraCuuVanBanFileAttach { get; set; }
        public virtual DbSet<CMS_TuyenTruyen> CMS_TuyenTruyen { get; set; }
        public virtual DbSet<CMS_TuyenTruyenFileAttach> CMS_TuyenTruyenFileAttach { get; set; }
        public virtual DbSet<CMS_Video> CMS_Video { get; set; }
        public virtual DbSet<CSV_CMS_BaiViet> CSV_CMS_BaiViet { get; set; }
        public virtual DbSet<CSV_CMS_BaiVietFileAttach> CSV_CMS_BaiVietFileAttach { get; set; }
        public virtual DbSet<CSV_CuuSinhVien> CSV_CuuSinhVien { get; set; }
        public virtual DbSet<CSV_CuuSinhVienBinhLuan> CSV_CuuSinhVienBinhLuan { get; set; }
        public virtual DbSet<CSV_DM_ChuDe> CSV_DM_ChuDe { get; set; }
        public virtual DbSet<DA_CongViec> DA_CongViec { get; set; }
        public virtual DbSet<DA_CongViec_LichSu> DA_CongViec_LichSu { get; set; }
        public virtual DbSet<DA_CongViec_LichSuFileAttach> DA_CongViec_LichSuFileAttach { get; set; }
        public virtual DbSet<DA_CongViecFileAttach> DA_CongViecFileAttach { get; set; }
        public virtual DbSet<DA_CongViecViewed> DA_CongViecViewed { get; set; }
        public virtual DbSet<DA_DinhMuc> DA_DinhMuc { get; set; }
        public virtual DbSet<DA_DoUuTien> DA_DoUuTien { get; set; }
        public virtual DbSet<DA_DuAn> DA_DuAn { get; set; }
        public virtual DbSet<DA_DuAn_Team> DA_DuAn_Team { get; set; }
        public virtual DbSet<DA_HangMucTrienKhai> DA_HangMucTrienKhai { get; set; }
        public virtual DbSet<DA_KhachHang> DA_KhachHang { get; set; }
        public virtual DbSet<DA_LoaiCongViec> DA_LoaiCongViec { get; set; }
        public virtual DbSet<DA_MucTieu> DA_MucTieu { get; set; }
        public virtual DbSet<DA_MucTieu_FileAttach> DA_MucTieu_FileAttach { get; set; }
        public virtual DbSet<DA_MucTieu_LichSu> DA_MucTieu_LichSu { get; set; }
        public virtual DbSet<DA_MucTieu_Nhom> DA_MucTieu_Nhom { get; set; }
        public virtual DbSet<DA_MucTieu_ThanhVien> DA_MucTieu_ThanhVien { get; set; }
        public virtual DbSet<DA_MucTieu_TrangThai> DA_MucTieu_TrangThai { get; set; }
        public virtual DbSet<DA_Team> DA_Team { get; set; }
        public virtual DbSet<DA_TeamThanhVien> DA_TeamThanhVien { get; set; }
        public virtual DbSet<DA_TienDoTrienKhai> DA_TienDoTrienKhai { get; set; }
        public virtual DbSet<DA_TrangThai> DA_TrangThai { get; set; }
        public virtual DbSet<DM_BacDaoTao> DM_BacDaoTao { get; set; }
        public virtual DbSet<DM_BaiViet> DM_BaiViet { get; set; }
        public virtual DbSet<DM_BangDongBo> DM_BangDongBo { get; set; }
        public virtual DbSet<DM_ChiDaoDieuHanh> DM_ChiDaoDieuHanh { get; set; }
        public virtual DbSet<DM_ChucVu> DM_ChucVu { get; set; }
        public virtual DbSet<DM_DanhHieu> DM_DanhHieu { get; set; }
        public virtual DbSet<DM_DanToc> DM_DanToc { get; set; }
        public virtual DbSet<DM_DaoTao> DM_DaoTao { get; set; }
        public virtual DbSet<DM_DaoTao_CauHinh> DM_DaoTao_CauHinh { get; set; }
        public virtual DbSet<DM_DonVi> DM_DonVi { get; set; }
        public virtual DbSet<DM_Dot> DM_Dot { get; set; }
        public virtual DbSet<DM_DuAnHangMucDauTu> DM_DuAnHangMucDauTu { get; set; }
        public virtual DbSet<DM_GiaoDien> DM_GiaoDien { get; set; }
        public virtual DbSet<DM_GioiThieu> DM_GioiThieu { get; set; }
        public virtual DbSet<DM_GioiThieu_CauHinh> DM_GioiThieu_CauHinh { get; set; }
        public virtual DbSet<DM_HocHam> DM_HocHam { get; set; }
        public virtual DbSet<DM_HocVi> DM_HocVi { get; set; }
        public virtual DbSet<DM_Huyen> DM_Huyen { get; set; }
        public virtual DbSet<DM_KeHoachLichCongTac> DM_KeHoachLichCongTac { get; set; }
        public virtual DbSet<DM_KhoaHoc> DM_KhoaHoc { get; set; }
        public virtual DbSet<DM_KhoaHocCongNghe> DM_KhoaHocCongNghe { get; set; }
        public virtual DbSet<DM_KhuVuc> DM_KhuVuc { get; set; }
        public virtual DbSet<DM_LinhVuc> DM_LinhVuc { get; set; }
        public virtual DbSet<DM_LoaiImage> DM_LoaiImage { get; set; }
        public virtual DbSet<DM_LoaiWebsite> DM_LoaiWebsite { get; set; }
        public virtual DbSet<DM_MultiLanguage> DM_MultiLanguage { get; set; }
        public virtual DbSet<DM_MultiLanguageChiTiet> DM_MultiLanguageChiTiet { get; set; }
        public virtual DbSet<DM_Nganh> DM_Nganh { get; set; }
        public virtual DbSet<DM_NganhDetail> DM_NganhDetail { get; set; }
        public virtual DbSet<DM_NganhTruong> DM_NganhTruong { get; set; }
        public virtual DbSet<DM_NganhTruongDetail> DM_NganhTruongDetail { get; set; }
        public virtual DbSet<DM_NganhTruongImages> DM_NganhTruongImages { get; set; }
        public virtual DbSet<DM_NhomNganh> DM_NhomNganh { get; set; }
        public virtual DbSet<DM_PhanLoaiKeyNgonNgu> DM_PhanLoaiKeyNgonNgu { get; set; }
        public virtual DbSet<DM_PhongBan> DM_PhongBan { get; set; }
        public virtual DbSet<DM_PhongGiaoDuc> DM_PhongGiaoDuc { get; set; }
        public virtual DbSet<DM_PhuongXa> DM_PhuongXa { get; set; }
        public virtual DbSet<DM_QuocGia> DM_QuocGia { get; set; }
        public virtual DbSet<DM_QuocTich> DM_QuocTich { get; set; }
        public virtual DbSet<DM_QuyHoachChienLuocKeHoach> DM_QuyHoachChienLuocKeHoach { get; set; }
        public virtual DbSet<DM_SanPham> DM_SanPham { get; set; }
        public virtual DbSet<DM_SoGiaoDuc> DM_SoGiaoDuc { get; set; }
        public virtual DbSet<DM_TD_TrangThai> DM_TD_TrangThai { get; set; }
        public virtual DbSet<DM_TD_ViTriViecLam> DM_TD_ViTriViecLam { get; set; }
        public virtual DbSet<DM_TenMien> DM_TenMien { get; set; }
        public virtual DbSet<DM_ThongKeBaoCao> DM_ThongKeBaoCao { get; set; }
        public virtual DbSet<DM_TinhThanh> DM_TinhThanh { get; set; }
        public virtual DbSet<DM_TinTuc> DM_TinTuc { get; set; }
        public virtual DbSet<DM_TinTuc_CauHinh> DM_TinTuc_CauHinh { get; set; }
        public virtual DbSet<DM_TonGiao> DM_TonGiao { get; set; }
        public virtual DbSet<DM_TraCuuVanBan> DM_TraCuuVanBan { get; set; }
        public virtual DbSet<DM_TrinhDoDaoTao> DM_TrinhDoDaoTao { get; set; }
        public virtual DbSet<DM_Truong> DM_Truong { get; set; }
        public virtual DbSet<DM_TruongDetail> DM_TruongDetail { get; set; }
        public virtual DbSet<DM_TruongImages> DM_TruongImages { get; set; }
        public virtual DbSet<DM_TuyenTruyen> DM_TuyenTruyen { get; set; }
        public virtual DbSet<DM_Website> DM_Website { get; set; }
        public virtual DbSet<DVC_CoQuan> DVC_CoQuan { get; set; }
        public virtual DbSet<EGOV_ApDungPhieuDanhGia> EGOV_ApDungPhieuDanhGia { get; set; }
        public virtual DbSet<EGOV_BaoCaoKeHoach> EGOV_BaoCaoKeHoach { get; set; }
        public virtual DbSet<EGOV_BaoCaoKeHoachACL> EGOV_BaoCaoKeHoachACL { get; set; }
        public virtual DbSet<EGOV_BaoCaoKeHoachFileAttach> EGOV_BaoCaoKeHoachFileAttach { get; set; }
        public virtual DbSet<EGOV_BaoCaoKeHoachViewed> EGOV_BaoCaoKeHoachViewed { get; set; }
        public virtual DbSet<EGOV_CongVanDen> EGOV_CongVanDen { get; set; }
        public virtual DbSet<EGOV_CongVanDenFileAttach> EGOV_CongVanDenFileAttach { get; set; }
        public virtual DbSet<EGOV_CongVanDenPhanCongXuLy> EGOV_CongVanDenPhanCongXuLy { get; set; }
        public virtual DbSet<EGOV_CongVanDenPhanCongXuLyFileAttach> EGOV_CongVanDenPhanCongXuLyFileAttach { get; set; }
        public virtual DbSet<EGOV_CongVanDenPhanCongXuLyLichSu> EGOV_CongVanDenPhanCongXuLyLichSu { get; set; }
        public virtual DbSet<EGOV_CongVanDi> EGOV_CongVanDi { get; set; }
        public virtual DbSet<EGOV_CongVanDi_BanHanh> EGOV_CongVanDi_BanHanh { get; set; }
        public virtual DbSet<EGOV_CongVanDiFileAttach> EGOV_CongVanDiFileAttach { get; set; }
        public virtual DbSet<EGOV_CongVanNoiBo_PhanCongXuLyLichSu> EGOV_CongVanNoiBo_PhanCongXuLyLichSu { get; set; }
        public virtual DbSet<EGOV_CongVanNoiBo_PhanCongXuLyLichSuFileAttach> EGOV_CongVanNoiBo_PhanCongXuLyLichSuFileAttach { get; set; }
        public virtual DbSet<EGOV_CoQuan> EGOV_CoQuan { get; set; }
        public virtual DbSet<EGOV_DangKySuDungXe> EGOV_DangKySuDungXe { get; set; }
        public virtual DbSet<EGOV_DangKyTangCa> EGOV_DangKyTangCa { get; set; }
        public virtual DbSet<EGOV_DangKyVang> EGOV_DangKyVang { get; set; }
        public virtual DbSet<EGOV_DangKyXe> EGOV_DangKyXe { get; set; }
        public virtual DbSet<EGOV_DM_DonViTinh> EGOV_DM_DonViTinh { get; set; }
        public virtual DbSet<EGOV_DM_LoaiXe> EGOV_DM_LoaiXe { get; set; }
        public virtual DbSet<EGOV_DM_LuaChon> EGOV_DM_LuaChon { get; set; }
        public virtual DbSet<EGOV_DM_NhaCungCap> EGOV_DM_NhaCungCap { get; set; }
        public virtual DbSet<EGOV_DM_NhomLuaChon> EGOV_DM_NhomLuaChon { get; set; }
        public virtual DbSet<EGOV_DM_PhieuDanhGia> EGOV_DM_PhieuDanhGia { get; set; }
        public virtual DbSet<EGOV_DM_PhieuDanhGiaChiTiet> EGOV_DM_PhieuDanhGiaChiTiet { get; set; }
        public virtual DbSet<EGOV_DM_TaiXe> EGOV_DM_TaiXe { get; set; }
        public virtual DbSet<EGOV_DM_Xe> EGOV_DM_Xe { get; set; }
        public virtual DbSet<EGOV_DotDanhGia> EGOV_DotDanhGia { get; set; }
        public virtual DbSet<EGOV_DotDanhGiaChiTiet> EGOV_DotDanhGiaChiTiet { get; set; }
        public virtual DbSet<EGOV_FileAttach> EGOV_FileAttach { get; set; }
        public virtual DbSet<EGOV_GiaoViec> EGOV_GiaoViec { get; set; }
        public virtual DbSet<EGOV_GiaoViec_LichSu> EGOV_GiaoViec_LichSu { get; set; }
        public virtual DbSet<EGOV_GiaoViec_NguoiGiamSat> EGOV_GiaoViec_NguoiGiamSat { get; set; }
        public virtual DbSet<EGOV_GiaoViec_Notify> EGOV_GiaoViec_Notify { get; set; }
        public virtual DbSet<EGOV_GiaoViecBaoCao> EGOV_GiaoViecBaoCao { get; set; }
        public virtual DbSet<EGOV_GiaoViecBaoCaoFileAttach> EGOV_GiaoViecBaoCaoFileAttach { get; set; }
        public virtual DbSet<EGOV_GiaoViecDetail> EGOV_GiaoViecDetail { get; set; }
        public virtual DbSet<EGOV_GiaoViecFileAttach> EGOV_GiaoViecFileAttach { get; set; }
        public virtual DbSet<EGOV_GiaoViecNhatKy> EGOV_GiaoViecNhatKy { get; set; }
        public virtual DbSet<EGOV_GiaoViecTrangThaiXuKy> EGOV_GiaoViecTrangThaiXuKy { get; set; }
        public virtual DbSet<EGOV_HopDongQuyetDinh> EGOV_HopDongQuyetDinh { get; set; }
        public virtual DbSet<EGOV_HopDongQuyetDinhFileAttach> EGOV_HopDongQuyetDinhFileAttach { get; set; }
        public virtual DbSet<EGOV_HoSo> EGOV_HoSo { get; set; }
        public virtual DbSet<EGOV_HoSo_CongViec> EGOV_HoSo_CongViec { get; set; }
        public virtual DbSet<EGOV_HoSo_CongViecDetail> EGOV_HoSo_CongViecDetail { get; set; }
        public virtual DbSet<EGOV_HoSo_CongViecFileAttach> EGOV_HoSo_CongViecFileAttach { get; set; }
        public virtual DbSet<EGOV_HoSo_LoaiDoiTuong> EGOV_HoSo_LoaiDoiTuong { get; set; }
        public virtual DbSet<EGOV_HoSo_LoaiHoSo> EGOV_HoSo_LoaiHoSo { get; set; }
        public virtual DbSet<EGOV_HoSo_TrangThai> EGOV_HoSo_TrangThai { get; set; }
        public virtual DbSet<EGOV_HoSoDonViCongDoan> EGOV_HoSoDonViCongDoan { get; set; }
        public virtual DbSet<EGOV_HoSoDonViDang> EGOV_HoSoDonViDang { get; set; }
        public virtual DbSet<EGOV_HoSoDonViDoanThanhNien> EGOV_HoSoDonViDoanThanhNien { get; set; }
        public virtual DbSet<EGOV_HoSoFileAttach> EGOV_HoSoFileAttach { get; set; }
        public virtual DbSet<EGOV_KetQuaDanhGia> EGOV_KetQuaDanhGia { get; set; }
        public virtual DbSet<EGOV_KhoiCoQuan> EGOV_KhoiCoQuan { get; set; }
        public virtual DbSet<EGOV_LichCongTac> EGOV_LichCongTac { get; set; }
        public virtual DbSet<EGOV_LichCongTac_LichSu> EGOV_LichCongTac_LichSu { get; set; }
        public virtual DbSet<EGOV_LichCongTac_PhongHop> EGOV_LichCongTac_PhongHop { get; set; }
        public virtual DbSet<EGOV_LichCongTacCaNhanACL> EGOV_LichCongTacCaNhanACL { get; set; }
        public virtual DbSet<EGOV_LichCongTacDetail> EGOV_LichCongTacDetail { get; set; }
        public virtual DbSet<EGOV_LichCongTacDiemDanh> EGOV_LichCongTacDiemDanh { get; set; }
        public virtual DbSet<EGOV_LichCongTacFileAttach> EGOV_LichCongTacFileAttach { get; set; }
        public virtual DbSet<EGOV_LoaiHopDongQuyetDinh> EGOV_LoaiHopDongQuyetDinh { get; set; }
        public virtual DbSet<EGOV_LoaiHoSo> EGOV_LoaiHoSo { get; set; }
        public virtual DbSet<EGOV_LoaiVanBan> EGOV_LoaiVanBan { get; set; }
        public virtual DbSet<EGOV_LoaiVanBan_Ver2> EGOV_LoaiVanBan_Ver2 { get; set; }
        public virtual DbSet<EGOV_LoaiVanBanCongDoan> EGOV_LoaiVanBanCongDoan { get; set; }
        public virtual DbSet<EGOV_LoaiVanBanDang> EGOV_LoaiVanBanDang { get; set; }
        public virtual DbSet<EGOV_LoaiVanBanDoanThanhNien> EGOV_LoaiVanBanDoanThanhNien { get; set; }
        public virtual DbSet<EGOV_MailBox> EGOV_MailBox { get; set; }
        public virtual DbSet<EGOV_MailFileAttach> EGOV_MailFileAttach { get; set; }
        public virtual DbSet<EGOV_MailNguoiNhan> EGOV_MailNguoiNhan { get; set; }
        public virtual DbSet<EGOV_NK_CongVanNoiBo> EGOV_NK_CongVanNoiBo { get; set; }
        public virtual DbSet<EGOV_NoiLuuTru> EGOV_NoiLuuTru { get; set; }
        public virtual DbSet<EGOV_NoiLuuTruCongDoan> EGOV_NoiLuuTruCongDoan { get; set; }
        public virtual DbSet<EGOV_NoiLuuTruDang> EGOV_NoiLuuTruDang { get; set; }
        public virtual DbSet<EGOV_NoiLuuTruDoanThanhNien> EGOV_NoiLuuTruDoanThanhNien { get; set; }
        public virtual DbSet<EGOV_PersonalWorkingOfWeeks> EGOV_PersonalWorkingOfWeeks { get; set; }
        public virtual DbSet<EGOV_PersonalWorkings> EGOV_PersonalWorkings { get; set; }
        public virtual DbSet<EGOV_PhanLoaiVanBan> EGOV_PhanLoaiVanBan { get; set; }
        public virtual DbSet<EGOV_SharePersonalWorkings> EGOV_SharePersonalWorkings { get; set; }
        public virtual DbSet<EGOV_SoVanBan> EGOV_SoVanBan { get; set; }
        public virtual DbSet<EGOV_SoVanBan_PhanCongPhuTrach> EGOV_SoVanBan_PhanCongPhuTrach { get; set; }
        public virtual DbSet<EGOV_SoVanBan_PhanQuyenXuLyVanBan> EGOV_SoVanBan_PhanQuyenXuLyVanBan { get; set; }
        public virtual DbSet<EGOV_ThongBao> EGOV_ThongBao { get; set; }
        public virtual DbSet<EGOV_ThongBao_TinhChat> EGOV_ThongBao_TinhChat { get; set; }
        public virtual DbSet<EGOV_ThongBaoDVPB> EGOV_ThongBaoDVPB { get; set; }
        public virtual DbSet<EGOV_ThongBaoFileAttach> EGOV_ThongBaoFileAttach { get; set; }
        public virtual DbSet<EGOV_ThongBaoViewed> EGOV_ThongBaoViewed { get; set; }
        public virtual DbSet<EGOV_TrinhKy> EGOV_TrinhKy { get; set; }
        public virtual DbSet<EGOV_TrinhKy_CauHinhChucDanh> EGOV_TrinhKy_CauHinhChucDanh { get; set; }
        public virtual DbSet<EGOV_TrinhKy_CauHinhChucDanhDetail> EGOV_TrinhKy_CauHinhChucDanhDetail { get; set; }
        public virtual DbSet<EGOV_TrinhKy_LichSu> EGOV_TrinhKy_LichSu { get; set; }
        public virtual DbSet<EGOV_TrinhKy_Notify> EGOV_TrinhKy_Notify { get; set; }
        public virtual DbSet<EGOV_TrinhKy_PhanCongNhanSuQuyTrinh> EGOV_TrinhKy_PhanCongNhanSuQuyTrinh { get; set; }
        public virtual DbSet<EGOV_TrinhKy_QuyTrinh> EGOV_TrinhKy_QuyTrinh { get; set; }
        public virtual DbSet<EGOV_TrinhKyDetail> EGOV_TrinhKyDetail { get; set; }
        public virtual DbSet<EGOV_TrinhKyFileAttach> EGOV_TrinhKyFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDen> EGOV_VanBanDen { get; set; }
        public virtual DbSet<EGOV_VanBanDen_CoQuanNhan> EGOV_VanBanDen_CoQuanNhan { get; set; }
        public virtual DbSet<EGOV_VanBanDen_Ver2> EGOV_VanBanDen_Ver2 { get; set; }
        public virtual DbSet<EGOV_VanBanDen_Ver2_ButPheLichSu> EGOV_VanBanDen_Ver2_ButPheLichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDen_Ver2_ButPheLichSuFileAttach> EGOV_VanBanDen_Ver2_ButPheLichSuFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDen_Ver2_FileAttach> EGOV_VanBanDen_Ver2_FileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDen_Ver2_PhanCongXuLy> EGOV_VanBanDen_Ver2_PhanCongXuLy { get; set; }
        public virtual DbSet<EGOV_VanBanDen_Ver2_PhanCongXuLyLichSu> EGOV_VanBanDen_Ver2_PhanCongXuLyLichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDen_Ver2_PhanCongXuLyLichSuFileAttach> EGOV_VanBanDen_Ver2_PhanCongXuLyLichSuFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenButPheFileAttach> EGOV_VanBanDenButPheFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenButPheLichSu> EGOV_VanBanDenButPheLichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDenCongDoan> EGOV_VanBanDenCongDoan { get; set; }
        public virtual DbSet<EGOV_VanBanDenCongDoan_CoQuanNhan> EGOV_VanBanDenCongDoan_CoQuanNhan { get; set; }
        public virtual DbSet<EGOV_VanBanDenCongDoanButPheFileAttach> EGOV_VanBanDenCongDoanButPheFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenCongDoanFileAttach> EGOV_VanBanDenCongDoanFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenCongDoanLichSu> EGOV_VanBanDenCongDoanLichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDenCongDoanPhanCongXuLy> EGOV_VanBanDenCongDoanPhanCongXuLy { get; set; }
        public virtual DbSet<EGOV_VanBanDenCongDoanPhanCongXuLyFileAttach> EGOV_VanBanDenCongDoanPhanCongXuLyFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenCongDoanPhanCongXuLyLichSu> EGOV_VanBanDenCongDoanPhanCongXuLyLichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDenDang> EGOV_VanBanDenDang { get; set; }
        public virtual DbSet<EGOV_VanBanDenDang_CoQuanNhan> EGOV_VanBanDenDang_CoQuanNhan { get; set; }
        public virtual DbSet<EGOV_VanBanDenDangButPheFileAttach> EGOV_VanBanDenDangButPheFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenDangFileAttach> EGOV_VanBanDenDangFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenDangLichSu> EGOV_VanBanDenDangLichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDenDangPhanCongXuLy> EGOV_VanBanDenDangPhanCongXuLy { get; set; }
        public virtual DbSet<EGOV_VanBanDenDangPhanCongXuLyFileAttach> EGOV_VanBanDenDangPhanCongXuLyFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenDangPhanCongXuLyLichSu> EGOV_VanBanDenDangPhanCongXuLyLichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDenDoanThanhNien> EGOV_VanBanDenDoanThanhNien { get; set; }
        public virtual DbSet<EGOV_VanBanDenDoanThanhNien_CoQuanNhan> EGOV_VanBanDenDoanThanhNien_CoQuanNhan { get; set; }
        public virtual DbSet<EGOV_VanBanDenDoanThanhNienButPheFileAttach> EGOV_VanBanDenDoanThanhNienButPheFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenDoanThanhNienFileAttach> EGOV_VanBanDenDoanThanhNienFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenDoanThanhNienLichSu> EGOV_VanBanDenDoanThanhNienLichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDenDoanThanhNienPhanCongXuLy> EGOV_VanBanDenDoanThanhNienPhanCongXuLy { get; set; }
        public virtual DbSet<EGOV_VanBanDenDoanThanhNienPhanCongXuLyFileAttach> EGOV_VanBanDenDoanThanhNienPhanCongXuLyFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenDoanThanhNienPhanCongXuLyLichSu> EGOV_VanBanDenDoanThanhNienPhanCongXuLyLichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDenFileAttach> EGOV_VanBanDenFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenLichSu> EGOV_VanBanDenLichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDenPhanCongXuLy> EGOV_VanBanDenPhanCongXuLy { get; set; }
        public virtual DbSet<EGOV_VanBanDenPhanCongXuLyFileAttach> EGOV_VanBanDenPhanCongXuLyFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDenPhanCongXuLyLichSu> EGOV_VanBanDenPhanCongXuLyLichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDenPhanCongXuLyViewed> EGOV_VanBanDenPhanCongXuLyViewed { get; set; }
        public virtual DbSet<EGOV_VanBanDenViewed> EGOV_VanBanDenViewed { get; set; }
        public virtual DbSet<EGOV_VanBanDi> EGOV_VanBanDi { get; set; }
        public virtual DbSet<EGOV_VanBanDi_BanHanh> EGOV_VanBanDi_BanHanh { get; set; }
        public virtual DbSet<EGOV_VanBanDi_BanHanhFileAttach> EGOV_VanBanDi_BanHanhFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDi_BanHanhViewed> EGOV_VanBanDi_BanHanhViewed { get; set; }
        public virtual DbSet<EGOV_VanBanDi_CoQuanNhan> EGOV_VanBanDi_CoQuanNhan { get; set; }
        public virtual DbSet<EGOV_VanBanDi_DuyetTrinhKy> EGOV_VanBanDi_DuyetTrinhKy { get; set; }
        public virtual DbSet<EGOV_VanBanDi_DuyetTrinhKyFileAttach> EGOV_VanBanDi_DuyetTrinhKyFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDi_LichSu> EGOV_VanBanDi_LichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDi_SendMailHistory> EGOV_VanBanDi_SendMailHistory { get; set; }
        public virtual DbSet<EGOV_VanBanDiCongDoan> EGOV_VanBanDiCongDoan { get; set; }
        public virtual DbSet<EGOV_VanBanDiCongDoan_BanHanh> EGOV_VanBanDiCongDoan_BanHanh { get; set; }
        public virtual DbSet<EGOV_VanBanDiCongDoan_BanHanhFileAttach> EGOV_VanBanDiCongDoan_BanHanhFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDiCongDoan_BanHanhViewed> EGOV_VanBanDiCongDoan_BanHanhViewed { get; set; }
        public virtual DbSet<EGOV_VanBanDiCongDoan_CoQuanNhan> EGOV_VanBanDiCongDoan_CoQuanNhan { get; set; }
        public virtual DbSet<EGOV_VanBanDiCongDoan_DuyetTrinhKy> EGOV_VanBanDiCongDoan_DuyetTrinhKy { get; set; }
        public virtual DbSet<EGOV_VanBanDiCongDoan_DuyetTrinhKyFileAttach> EGOV_VanBanDiCongDoan_DuyetTrinhKyFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDiCongDoan_LichSu> EGOV_VanBanDiCongDoan_LichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDiCongDoanFileAttach> EGOV_VanBanDiCongDoanFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDiDang> EGOV_VanBanDiDang { get; set; }
        public virtual DbSet<EGOV_VanBanDiDang_BanHanh> EGOV_VanBanDiDang_BanHanh { get; set; }
        public virtual DbSet<EGOV_VanBanDiDang_BanHanhFileAttach> EGOV_VanBanDiDang_BanHanhFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDiDang_BanHanhViewed> EGOV_VanBanDiDang_BanHanhViewed { get; set; }
        public virtual DbSet<EGOV_VanBanDiDang_CoQuanNhan> EGOV_VanBanDiDang_CoQuanNhan { get; set; }
        public virtual DbSet<EGOV_VanBanDiDang_DuyetTrinhKy> EGOV_VanBanDiDang_DuyetTrinhKy { get; set; }
        public virtual DbSet<EGOV_VanBanDiDang_DuyetTrinhKyFileAttach> EGOV_VanBanDiDang_DuyetTrinhKyFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDiDang_LichSu> EGOV_VanBanDiDang_LichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDiDangFileAttach> EGOV_VanBanDiDangFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDiDoanThanhNien> EGOV_VanBanDiDoanThanhNien { get; set; }
        public virtual DbSet<EGOV_VanBanDiDoanThanhNien_BanHanh> EGOV_VanBanDiDoanThanhNien_BanHanh { get; set; }
        public virtual DbSet<EGOV_VanBanDiDoanThanhNien_BanHanhFileAttach> EGOV_VanBanDiDoanThanhNien_BanHanhFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDiDoanThanhNien_BanHanhViewed> EGOV_VanBanDiDoanThanhNien_BanHanhViewed { get; set; }
        public virtual DbSet<EGOV_VanBanDiDoanThanhNien_CoQuanNhan> EGOV_VanBanDiDoanThanhNien_CoQuanNhan { get; set; }
        public virtual DbSet<EGOV_VanBanDiDoanThanhNien_DuyetTrinhKy> EGOV_VanBanDiDoanThanhNien_DuyetTrinhKy { get; set; }
        public virtual DbSet<EGOV_VanBanDiDoanThanhNien_DuyetTrinhKyFileAttach> EGOV_VanBanDiDoanThanhNien_DuyetTrinhKyFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDiDoanThanhNien_LichSu> EGOV_VanBanDiDoanThanhNien_LichSu { get; set; }
        public virtual DbSet<EGOV_VanBanDiDoanThanhNienFileAttach> EGOV_VanBanDiDoanThanhNienFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanDiFileAttach> EGOV_VanBanDiFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanHanhChinh> EGOV_VanBanHanhChinh { get; set; }
        public virtual DbSet<EGOV_VanBanHanhChinh_CapNhatLoi> EGOV_VanBanHanhChinh_CapNhatLoi { get; set; }
        public virtual DbSet<EGOV_VanBanHanhChinh_CapNhatLoiFileAttach> EGOV_VanBanHanhChinh_CapNhatLoiFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanHanhChinh_LichSuDanhGia> EGOV_VanBanHanhChinh_LichSuDanhGia { get; set; }
        public virtual DbSet<EGOV_VanBanHanhChinh_LichSuDanhGiaFileAttach> EGOV_VanBanHanhChinh_LichSuDanhGiaFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanHanhChinh_TrangThai> EGOV_VanBanHanhChinh_TrangThai { get; set; }
        public virtual DbSet<EGOV_VanBanHanhChinhFileAttach> EGOV_VanBanHanhChinhFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_Config> EGOV_VanBanLienThong_Config { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_CoQuan> EGOV_VanBanLienThong_CoQuan { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_Den> EGOV_VanBanLienThong_Den { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_DenFileAttach> EGOV_VanBanLienThong_DenFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_DenReplacementInfo> EGOV_VanBanLienThong_DenReplacementInfo { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_DenResponseFor> EGOV_VanBanLienThong_DenResponseFor { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_DenTo> EGOV_VanBanLienThong_DenTo { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_DenTrangThai> EGOV_VanBanLienThong_DenTrangThai { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_Di> EGOV_VanBanLienThong_Di { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_DiFileAttach> EGOV_VanBanLienThong_DiFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_DiLichSu> EGOV_VanBanLienThong_DiLichSu { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_DiReplacementInfo> EGOV_VanBanLienThong_DiReplacementInfo { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_DiTo> EGOV_VanBanLienThong_DiTo { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_DiTrangThai> EGOV_VanBanLienThong_DiTrangThai { get; set; }
        public virtual DbSet<EGOV_VanBanLienThong_DocumentType> EGOV_VanBanLienThong_DocumentType { get; set; }
        public virtual DbSet<EGOV_VanBanMau> EGOV_VanBanMau { get; set; }
        public virtual DbSet<EGOV_VanBanMauFileAttach> EGOV_VanBanMauFileAttach { get; set; }
        public virtual DbSet<EGOV_VanBanPhoCap> EGOV_VanBanPhoCap { get; set; }
        public virtual DbSet<EGOV_VanBanPhoCapFileAttach> EGOV_VanBanPhoCapFileAttach { get; set; }
        public virtual DbSet<EGOV_VPP> EGOV_VPP { get; set; }
        public virtual DbSet<EGOV_VPP_ChiTietDeXuat> EGOV_VPP_ChiTietDeXuat { get; set; }
        public virtual DbSet<EGOV_VPP_DeXuat> EGOV_VPP_DeXuat { get; set; }
        public virtual DbSet<EGOV_VPP_DM_PhanLoai> EGOV_VPP_DM_PhanLoai { get; set; }
        public virtual DbSet<EGOV_VPP_LichSuDeXuat> EGOV_VPP_LichSuDeXuat { get; set; }
        public virtual DbSet<EGOV_VPP_TrangThai> EGOV_VPP_TrangThai { get; set; }
        public virtual DbSet<EGOV_YeuCauCongViec_CauHinhChucDanh> EGOV_YeuCauCongViec_CauHinhChucDanh { get; set; }
        public virtual DbSet<EGOV_YeuCauCongViec_CauHinhChucDanhDetail> EGOV_YeuCauCongViec_CauHinhChucDanhDetail { get; set; }
        public virtual DbSet<EGOV_YeuCauCongViec_PhanQuyenXuLyTheoQuyTrinh> EGOV_YeuCauCongViec_PhanQuyenXuLyTheoQuyTrinh { get; set; }
        public virtual DbSet<EGOV_YeuCauCongViec_PhieuYeuCau> EGOV_YeuCauCongViec_PhieuYeuCau { get; set; }
        public virtual DbSet<EGOV_YeuCauCongViec_PhieuYeuCauDetail> EGOV_YeuCauCongViec_PhieuYeuCauDetail { get; set; }
        public virtual DbSet<EGOV_YeuCauCongViec_PhieuYeuCauFileAttach> EGOV_YeuCauCongViec_PhieuYeuCauFileAttach { get; set; }
        public virtual DbSet<EGOV_YeuCauCongViec_PhieuYeuCauTiepNhanDetail> EGOV_YeuCauCongViec_PhieuYeuCauTiepNhanDetail { get; set; }
        public virtual DbSet<ELN_ACL_LoaiTaiLieu> ELN_ACL_LoaiTaiLieu { get; set; }
        public virtual DbSet<ELN_BaiGiang> ELN_BaiGiang { get; set; }
        public virtual DbSet<ELN_BaiGiang_LichSu> ELN_BaiGiang_LichSu { get; set; }
        public virtual DbSet<ELN_BaiGiangComment> ELN_BaiGiangComment { get; set; }
        public virtual DbSet<ELN_BaiGiangFileAttach> ELN_BaiGiangFileAttach { get; set; }
        public virtual DbSet<ELN_LichHoc> ELN_LichHoc { get; set; }
        public virtual DbSet<ELN_LoaiBaiGiang> ELN_LoaiBaiGiang { get; set; }
        public virtual DbSet<ELN_LoaiTaiLieu> ELN_LoaiTaiLieu { get; set; }
        public virtual DbSet<ELN_NhomBaiGiang> ELN_NhomBaiGiang { get; set; }
        public virtual DbSet<ELN_TaiLieu> ELN_TaiLieu { get; set; }
        public virtual DbSet<ELN_TaiLieuFileAttach> ELN_TaiLieuFileAttach { get; set; }
        public virtual DbSet<ES_NhanSu_NhomNhanSu> ES_NhanSu_NhomNhanSu { get; set; }
        public virtual DbSet<ES_NhomNhanSu> ES_NhomNhanSu { get; set; }
        public virtual DbSet<Express_BangGia> Express_BangGia { get; set; }
        public virtual DbSet<Express_CongTyChuyenPhat> Express_CongTyChuyenPhat { get; set; }
        public virtual DbSet<Express_DeXuatChuyenPhat> Express_DeXuatChuyenPhat { get; set; }
        public virtual DbSet<Express_GiaCPN> Express_GiaCPN { get; set; }
        public virtual DbSet<Express_LichSuDeXuat> Express_LichSuDeXuat { get; set; }
        public virtual DbSet<Express_LichSuNhan> Express_LichSuNhan { get; set; }
        public virtual DbSet<Express_LoaiChuyenPhat> Express_LoaiChuyenPhat { get; set; }
        public virtual DbSet<Express_NhanBuuPham> Express_NhanBuuPham { get; set; }
        public virtual DbSet<Express_QuocGia> Express_QuocGia { get; set; }
        public virtual DbSet<Express_TinhThanh> Express_TinhThanh { get; set; }
        public virtual DbSet<FILE_QuanLyFile> FILE_QuanLyFile { get; set; }
        public virtual DbSet<FILE_ThuMuc> FILE_ThuMuc { get; set; }
        public virtual DbSet<HoiDap_CauHoi> HoiDap_CauHoi { get; set; }
        public virtual DbSet<HoiDap_CauTraLoi> HoiDap_CauTraLoi { get; set; }
        public virtual DbSet<HoiDap_DonVi> HoiDap_DonVi { get; set; }
        public virtual DbSet<HoiDap_LinhVuc> HoiDap_LinhVuc { get; set; }
        public virtual DbSet<HT_LichSuDangNhap> HT_LichSuDangNhap { get; set; }
        public virtual DbSet<HT_LichSuThaoTac> HT_LichSuThaoTac { get; set; }
        public virtual DbSet<JOB_BangCap> JOB_BangCap { get; set; }
        public virtual DbSet<JOB_CapBac> JOB_CapBac { get; set; }
        public virtual DbSet<JOB_CongTy> JOB_CongTy { get; set; }
        public virtual DbSet<JOB_DiaDiem> JOB_DiaDiem { get; set; }
        public virtual DbSet<JOB_FORM_DonMau> JOB_FORM_DonMau { get; set; }
        public virtual DbSet<JOB_FORM_DonMauFileAttach> JOB_FORM_DonMauFileAttach { get; set; }
        public virtual DbSet<JOB_FORM_LoaiDonMau> JOB_FORM_LoaiDonMau { get; set; }
        public virtual DbSet<JOB_HocVanUngVien> JOB_HocVanUngVien { get; set; }
        public virtual DbSet<JOB_KhoaDaoTao> JOB_KhoaDaoTao { get; set; }
        public virtual DbSet<JOB_KinhNghiem> JOB_KinhNghiem { get; set; }
        public virtual DbSet<JOB_KinhNghiemUngVien> JOB_KinhNghiemUngVien { get; set; }
        public virtual DbSet<JOB_KyNang> JOB_KyNang { get; set; }
        public virtual DbSet<JOB_LoaiHinhCongViec> JOB_LoaiHinhCongViec { get; set; }
        public virtual DbSet<JOB_MucLuong> JOB_MucLuong { get; set; }
        public virtual DbSet<JOB_MucTieu> JOB_MucTieu { get; set; }
        public virtual DbSet<JOB_NganhNghe> JOB_NganhNghe { get; set; }
        public virtual DbSet<JOB_NgonNgu> JOB_NgonNgu { get; set; }
        public virtual DbSet<JOB_Truong> JOB_Truong { get; set; }
        public virtual DbSet<JOB_UngVien> JOB_UngVien { get; set; }
        public virtual DbSet<JOB_UngVienLoaiHinhCVMongMuon> JOB_UngVienLoaiHinhCVMongMuon { get; set; }
        public virtual DbSet<JOB_UngVienNganhNgheMongMuon> JOB_UngVienNganhNgheMongMuon { get; set; }
        public virtual DbSet<JOB_UngVienNoiLamMongMuon> JOB_UngVienNoiLamMongMuon { get; set; }
        public virtual DbSet<JOB_ViecLam> JOB_ViecLam { get; set; }
        public virtual DbSet<JOB_ViecLamDaLuu> JOB_ViecLamDaLuu { get; set; }
        public virtual DbSet<JOB_ViecLamDaUngTuyen> JOB_ViecLamDaUngTuyen { get; set; }
        public virtual DbSet<JOB_ViecLamDiaDiemLamViec> JOB_ViecLamDiaDiemLamViec { get; set; }
        public virtual DbSet<JOB_ViecLamNganhNgheCanTuyen> JOB_ViecLamNganhNgheCanTuyen { get; set; }
        public virtual DbSet<JOB_XepLoai> JOB_XepLoai { get; set; }
        public virtual DbSet<KeHoachTuyenDung> KeHoachTuyenDungs { get; set; }
        public virtual DbSet<KeHoachTuyenDung_ChiTiet> KeHoachTuyenDung_ChiTiet { get; set; }
        public virtual DbSet<KH_DoNghiemTrong> KH_DoNghiemTrong { get; set; }
        public virtual DbSet<KH_DotRelease> KH_DotRelease { get; set; }
        public virtual DbSet<KH_DotRelease_LichSu> KH_DotRelease_LichSu { get; set; }
        public virtual DbSet<KH_DoUuTien> KH_DoUuTien { get; set; }
        public virtual DbSet<KH_Loai> KH_Loai { get; set; }
        public virtual DbSet<KH_PhanHe> KH_PhanHe { get; set; }
        public virtual DbSet<KH_ThongBaoBaoTri> KH_ThongBaoBaoTri { get; set; }
        public virtual DbSet<KH_TrangThai> KH_TrangThai { get; set; }
        public virtual DbSet<KH_TrangThaiDotRelease> KH_TrangThaiDotRelease { get; set; }
        public virtual DbSet<KH_TrangThaiPhieuYeuCau> KH_TrangThaiPhieuYeuCau { get; set; }
        public virtual DbSet<KH_YeuCau> KH_YeuCau { get; set; }
        public virtual DbSet<KH_YeuCau_LichSu> KH_YeuCau_LichSu { get; set; }
        public virtual DbSet<KH_YeuCau_LichSuFileAttach> KH_YeuCau_LichSuFileAttach { get; set; }
        public virtual DbSet<KH_YeuCau_PhieuYeuCau> KH_YeuCau_PhieuYeuCau { get; set; }
        public virtual DbSet<KH_YeuCau_PhieuYeuCauFileAttach> KH_YeuCau_PhieuYeuCauFileAttach { get; set; }
        public virtual DbSet<KH_YeuCauFileAttach> KH_YeuCauFileAttach { get; set; }
        public virtual DbSet<MES_Messages> MES_Messages { get; set; }
        public virtual DbSet<NOF_Devices> NOF_Devices { get; set; }
        public virtual DbSet<NOF_NotifyLog> NOF_NotifyLog { get; set; }
        public virtual DbSet<SHR_VanBanDieuHanh> SHR_VanBanDieuHanh { get; set; }
        public virtual DbSet<SHR_VanBanPhapLuat> SHR_VanBanPhapLuat { get; set; }
        public virtual DbSet<SP_ChiTietChucNang> SP_ChiTietChucNang { get; set; }
        public virtual DbSet<SP_ChucNang> SP_ChucNang { get; set; }
        public virtual DbSet<SP_PhanLoaiChucNang> SP_PhanLoaiChucNang { get; set; }
        public virtual DbSet<SV_LienHe> SV_LienHe { get; set; }
        public virtual DbSet<SV_LienHeReply> SV_LienHeReply { get; set; }
        public virtual DbSet<SV_NhatKyVaoTruong> SV_NhatKyVaoTruong { get; set; }
        public virtual DbSet<SYS_BieuMau> SYS_BieuMau { get; set; }
        public virtual DbSet<SYS_CaiDatCauHinh> SYS_CaiDatCauHinh { get; set; }
        public virtual DbSet<SYS_CauHinh> SYS_CauHinh { get; set; }
        public virtual DbSet<SYS_ChuKyDienTu> SYS_ChuKyDienTu { get; set; }
        public virtual DbSet<SYS_Config> SYS_Config { get; set; }
        public virtual DbSet<SYS_Config_KhachHang> SYS_Config_KhachHang { get; set; }
        public virtual DbSet<SYS_Mail> SYS_Mail { get; set; }
        public virtual DbSet<SYS_MailContent> SYS_MailContent { get; set; }
        public virtual DbSet<SYS_Menu> SYS_Menu { get; set; }
        public virtual DbSet<SYS_MenuActive> SYS_MenuActive { get; set; }
        public virtual DbSet<SYS_MenuSinhVien> SYS_MenuSinhVien { get; set; }
        public virtual DbSet<SYS_NhomCauHinh> SYS_NhomCauHinh { get; set; }
        public virtual DbSet<SYS_Resource> SYS_Resource { get; set; }
        public virtual DbSet<SYS_SendMailContent> SYS_SendMailContent { get; set; }
        public virtual DbSet<SYS_SendMailHistory> SYS_SendMailHistory { get; set; }
        public virtual DbSet<SYS_SetConfig> SYS_SetConfig { get; set; }
        public virtual DbSet<SYS_TableImport> SYS_TableImport { get; set; }
        public virtual DbSet<SYS_TableImportDetail> SYS_TableImportDetail { get; set; }
        public virtual DbSet<SYS_Template> SYS_Template { get; set; }
        public virtual DbSet<SYS_ThongKeTruyCap> SYS_ThongKeTruyCap { get; set; }
        public virtual DbSet<SYS_ThongKeTruyCapDetail> SYS_ThongKeTruyCapDetail { get; set; }
        public virtual DbSet<SYS_TimeLine> SYS_TimeLine { get; set; }
        public virtual DbSet<Sys_VanBanDen_SetTimKiem> Sys_VanBanDen_SetTimKiem { get; set; }
        public virtual DbSet<Sys_VanBanDen_TimKiem> Sys_VanBanDen_TimKiem { get; set; }
        public virtual DbSet<SYS_Widget> SYS_Widget { get; set; }
        public virtual DbSet<t_News_Faculties> t_News_Faculties { get; set; }
        public virtual DbSet<TAX_TrangThaiXuLy> TAX_TrangThaiXuLy { get; set; }
        public virtual DbSet<TD_QuanLyFileAttach> TD_QuanLyFileAttach { get; set; }
        public virtual DbSet<TD_UngVien_FileAttach> TD_UngVien_FileAttach { get; set; }
        public virtual DbSet<TEL_DangKyDienThoai> TEL_DangKyDienThoai { get; set; }
        public virtual DbSet<TEL_DM_GoiCuoc> TEL_DM_GoiCuoc { get; set; }
        public virtual DbSet<TEL_DM_MangDienThoai> TEL_DM_MangDienThoai { get; set; }
        public virtual DbSet<TEL_DM_SoDienThoai> TEL_DM_SoDienThoai { get; set; }
        public virtual DbSet<TEL_TienDienThoai> TEL_TienDienThoai { get; set; }
        public virtual DbSet<TL_DanhMuc> TL_DanhMuc { get; set; }
        public virtual DbSet<TL_TaiLieu> TL_TaiLieu { get; set; }
        public virtual DbSet<TL_TaiLieuFileAttach> TL_TaiLieuFileAttach { get; set; }
        public virtual DbSet<TNTS_CauHoi> TNTS_CauHoi { get; set; }
        public virtual DbSet<TNTS_KetQua> TNTS_KetQua { get; set; }
        public virtual DbSet<TNTS_NhomCauHoi> TNTS_NhomCauHoi { get; set; }
        public virtual DbSet<TNTS_TracNghiemNgheNghiep> TNTS_TracNghiemNgheNghiep { get; set; }
        public virtual DbSet<TS_LichSuImport> TS_LichSuImport { get; set; }
        public virtual DbSet<TS_LichSuImportDetail> TS_LichSuImportDetail { get; set; }
        public virtual DbSet<TSHN_DanhMucTinTuc> TSHN_DanhMucTinTuc { get; set; }
        public virtual DbSet<TSHN_DM_ChuDe> TSHN_DM_ChuDe { get; set; }
        public virtual DbSet<TSHN_DM_ChuongTrinhDaoTao> TSHN_DM_ChuongTrinhDaoTao { get; set; }
        public virtual DbSet<TSHN_DM_Khoa> TSHN_DM_Khoa { get; set; }
        public virtual DbSet<TSHN_DM_KhoiThi> TSHN_DM_KhoiThi { get; set; }
        public virtual DbSet<TSHN_DM_Nganh> TSHN_DM_Nganh { get; set; }
        public virtual DbSet<TSHN_DM_Nghe> TSHN_DM_Nghe { get; set; }
        public virtual DbSet<TSHN_GioiThieuChung> TSHN_GioiThieuChung { get; set; }
        public virtual DbSet<TSHN_LivestreamsInfo> TSHN_LivestreamsInfo { get; set; }
        public virtual DbSet<TSHN_TinTuc> TSHN_TinTuc { get; set; }
        public virtual DbSet<TSHN_TinTucFileAttach> TSHN_TinTucFileAttach { get; set; }
        public virtual DbSet<TSHN_TrangGioiThieu> TSHN_TrangGioiThieu { get; set; }
        public virtual DbSet<UngVien> UngViens { get; set; }
        public virtual DbSet<UngVien_LichSu> UngVien_LichSu { get; set; }
        public virtual DbSet<VBDH_CoQuan> VBDH_CoQuan { get; set; }
        public virtual DbSet<VBDH_DM_LoaiVanBanLienQuan> VBDH_DM_LoaiVanBanLienQuan { get; set; }
        public virtual DbSet<VBDH_LinhVuc> VBDH_LinhVuc { get; set; }
        public virtual DbSet<VBDH_LoaiVanBan> VBDH_LoaiVanBan { get; set; }
        public virtual DbSet<VBDH_NhomVanBan> VBDH_NhomVanBan { get; set; }
        public virtual DbSet<VBDH_TrangThai> VBDH_TrangThai { get; set; }
        public virtual DbSet<VBDH_VanBan> VBDH_VanBan { get; set; }
        public virtual DbSet<VBDH_VanBanFileAttach> VBDH_VanBanFileAttach { get; set; }
        public virtual DbSet<VBDH_VanBanLienQuan> VBDH_VanBanLienQuan { get; set; }
        public virtual DbSet<VBPL_CoQuan> VBPL_CoQuan { get; set; }
        public virtual DbSet<VBPL_LinhVuc> VBPL_LinhVuc { get; set; }
        public virtual DbSet<VBPL_LoaiVanBan> VBPL_LoaiVanBan { get; set; }
        public virtual DbSet<VBPL_Nganh> VBPL_Nganh { get; set; }
        public virtual DbSet<VBPL_PhamVi> VBPL_PhamVi { get; set; }
        public virtual DbSet<VBPL_TrangThai> VBPL_TrangThai { get; set; }
        public virtual DbSet<VBPL_VanBan> VBPL_VanBan { get; set; }
        public virtual DbSet<VBPL_VanBanFileAttach> VBPL_VanBanFileAttach { get; set; }
        public virtual DbSet<Xe_DangKyXe> Xe_DangKyXe { get; set; }
        public virtual DbSet<Xe_DangKyXeNguoiDi> Xe_DangKyXeNguoiDi { get; set; }
        public virtual DbSet<Xe_LichSuDangKy> Xe_LichSuDangKy { get; set; }
        public virtual DbSet<Xe_LoaiXe> Xe_LoaiXe { get; set; }
        public virtual DbSet<Xe_TaiXe> Xe_TaiXe { get; set; }
        public virtual DbSet<Xe_XeOTo> Xe_XeOTo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACL_ManHinh>()
                .Property(e => e.TenAction)
                .IsUnicode(false);

            modelBuilder.Entity<ACL_ManHinh>()
                .Property(e => e.TenController)
                .IsUnicode(false);

            modelBuilder.Entity<ACL_ManHinh>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<ACL_ManHinh>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<ACL_NhomNguoiDung>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ACL_NhomNguoiDung>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<ACL_TaiKhoan>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ACL_TaiKhoan>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<Ads_QuangCao>()
                .Property(e => e.GiaTienQuangCao)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ASC_ChiTieuNoiBo>()
                .Property(e => e.SoTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ASC_ChiTieuNoiBo_ChiTiet>()
                .Property(e => e.SoTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ASC_DatVe>()
                .Property(e => e.SoTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ASC_HopDong>()
                .Property(e => e.GiaTriHopDong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ASC_TamUng>()
                .Property(e => e.SoTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ASC_TamUng_ChiTiet>()
                .Property(e => e.SoTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CMS_BinhChonAnh_Detail>()
                .Property(e => e.IPAdress)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_BinhChonAnh_Detail>()
                .Property(e => e.OsName)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_BinhChonAnh_Detail>()
                .Property(e => e.OsVersion)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_BinhChonAnh_Detail>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_BinhChonAnh_Detail>()
                .Property(e => e.EngineName)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_BinhChonAnh_Detail>()
                .Property(e => e.EngineVersion)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_BinhChonAnh_Detail>()
                .Property(e => e.BrowserName)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_BinhChonAnh_Detail>()
                .Property(e => e.BrowserVersion)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_ChiDaoDieuHanh>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_DaoTao>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_DiaDiemThamQuan>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_DoanhNghiep>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_DoiSongSinhVien>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_DuAnHangMucDauTu>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_GioiThieu>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_HoiDongNhanDan>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_KeHoachLichCongTac>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_Menu>()
                .Property(e => e.ClassCss)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_NganhNgheTruyenThong>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_QuyHoachChienLuocKeHoach>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_Router>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_SanPham>()
                .Property(e => e.GiaBan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CMS_SanPham>()
                .Property(e => e.GiaSoSanh)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CMS_SanPham>()
                .Property(e => e.KhoiLuong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CMS_ThongKeBaoCao>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_TinTuc>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_TraCuuVanBan>()
                .Property(e => e.SoHieu)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_TraCuuVanBan>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_TraCuuVanBan>()
                .Property(e => e.Link)
                .IsFixedLength();

            modelBuilder.Entity<CMS_TuyenTruyen>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<CSV_CMS_BaiViet>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<DA_CongViec>()
                .Property(e => e.MaCongViec)
                .IsUnicode(false);

            modelBuilder.Entity<DA_CongViec>()
                .Property(e => e.Diem_DEV)
                .HasPrecision(5, 2);

            modelBuilder.Entity<DA_CongViec>()
                .Property(e => e.Diem_LEA)
                .HasPrecision(5, 2);

            modelBuilder.Entity<DA_CongViec>()
                .Property(e => e.DiemTB)
                .HasPrecision(5, 2);

            modelBuilder.Entity<DA_CongViec>()
                .Property(e => e.MaYeuCau)
                .IsUnicode(false);

            modelBuilder.Entity<DA_DinhMuc>()
                .Property(e => e.MaDinhMuc)
                .IsUnicode(false);

            modelBuilder.Entity<DA_DinhMuc>()
                .Property(e => e.DoKho)
                .IsUnicode(false);

            modelBuilder.Entity<DA_DuAn>()
                .Property(e => e.MaDuAn)
                .IsUnicode(false);

            modelBuilder.Entity<DA_DuAn>()
                .Property(e => e.TongTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DA_KhachHang>()
                .Property(e => e.MaMap)
                .IsUnicode(false);

            modelBuilder.Entity<DM_BacDaoTao>()
                .Property(e => e.MaBacDaoTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_DanhHieu>()
                .Property(e => e.MaDanhHieu)
                .IsUnicode(false);

            modelBuilder.Entity<DM_DanToc>()
                .Property(e => e.MaDanToc)
                .IsUnicode(false);

            modelBuilder.Entity<DM_Dot>()
                .Property(e => e.MaDot)
                .IsUnicode(false);

            modelBuilder.Entity<DM_GiaoDien>()
                .Property(e => e.MaTheme)
                .IsUnicode(false);

            modelBuilder.Entity<DM_Huyen>()
                .Property(e => e.MaHuyen)
                .IsUnicode(false);

            modelBuilder.Entity<DM_KhuVuc>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<DM_LinhVuc>()
                .Property(e => e.MaLinhVuc)
                .IsUnicode(false);

            modelBuilder.Entity<DM_LinhVuc>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<DM_MultiLanguage>()
                .Property(e => e.PhanLoai)
                .IsUnicode(false);

            modelBuilder.Entity<DM_MultiLanguageChiTiet>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<DM_Nganh>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<DM_NganhTruongImages>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<DM_NhomNganh>()
                .Property(e => e.MaNhomNganh)
                .IsUnicode(false);

            modelBuilder.Entity<DM_QuocTich>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<DM_TenMien>()
                .Property(e => e.TenMien)
                .IsUnicode(false);

            modelBuilder.Entity<DM_TinhThanh>()
                .Property(e => e.MaTinh)
                .IsUnicode(false);

            modelBuilder.Entity<DM_TonGiao>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<DM_TrinhDoDaoTao>()
                .Property(e => e.MaTrinhDoDaoTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_Truong>()
                .Property(e => e.MaTruong)
                .IsUnicode(false);

            modelBuilder.Entity<DM_TruongImages>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<DM_Website>()
                .Property(e => e.MaWeb)
                .IsUnicode(false);

            modelBuilder.Entity<DM_Website>()
                .Property(e => e.UniversityID)
                .IsUnicode(false);

            modelBuilder.Entity<DM_Website>()
                .Property(e => e.DBHRM)
                .IsUnicode(false);

            modelBuilder.Entity<DM_Website>()
                .Property(e => e.SystemID)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_CoQuan>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_DM_DonViTinh>()
                .Property(e => e.MaDVT)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_DM_NhaCungCap>()
                .Property(e => e.MaNhaCungCap)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_DM_NhaCungCap>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_DM_NhaCungCap>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_DM_PhieuDanhGiaChiTiet>()
                .Property(e => e.HeSoDiem)
                .HasPrecision(5, 2);

            modelBuilder.Entity<EGOV_FileAttach>()
                .Property(e => e.CheckSum)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_GiaoViec>()
                .Property(e => e.MaCongViec)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_LichCongTac>()
                .Property(e => e.MauSac)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_LichCongTac>()
                .Property(e => e.MauNen)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_LichCongTac_PhongHop>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_LoaiHopDongQuyetDinh>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_LoaiVanBan>()
                .Property(e => e.MaLoaiVanBan)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_LoaiVanBan_Ver2>()
                .Property(e => e.MaLoaiVanBan)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_LoaiVanBanCongDoan>()
                .Property(e => e.MaLoaiVanBan)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_LoaiVanBanDang>()
                .Property(e => e.MaLoaiVanBan)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_LoaiVanBanDoanThanhNien>()
                .Property(e => e.MaLoaiVanBan)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_PhanLoaiVanBan>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_ThongBao_TinhChat>()
                .Property(e => e.MaTinhChat)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_TrinhKy>()
                .Property(e => e.MaYeuCau)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_VanBanLienThong_DiTrangThai>()
                .Property(e => e.StatusCode)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_VanBanLienThong_DiTrangThai>()
                .Property(e => e.FromOrganId)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_VPP>()
                .Property(e => e.MaVPP)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_VPP>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EGOV_VPP_ChiTietDeXuat>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EGOV_VPP_ChiTietDeXuat>()
                .Property(e => e.ThanhTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EGOV_VPP_DeXuat>()
                .Property(e => e.MaDeXuat)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_VPP_DeXuat>()
                .Property(e => e.MaHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_VPP_DM_PhanLoai>()
                .Property(e => e.MaPhanLoai)
                .IsUnicode(false);

            modelBuilder.Entity<EGOV_YeuCauCongViec_PhieuYeuCau>()
                .Property(e => e.MaPhieuYeuCau)
                .IsUnicode(false);

            modelBuilder.Entity<ELN_BaiGiang>()
                .Property(e => e.SEO_URL)
                .IsUnicode(false);

            modelBuilder.Entity<ELN_LichHoc>()
                .Property(e => e.MauSac)
                .IsUnicode(false);

            modelBuilder.Entity<ELN_LichHoc>()
                .Property(e => e.MauNen)
                .IsUnicode(false);

            modelBuilder.Entity<ELN_LoaiBaiGiang>()
                .Property(e => e.SEO_URL)
                .IsUnicode(false);

            modelBuilder.Entity<ELN_NhomBaiGiang>()
                .Property(e => e.SEO_URL)
                .IsUnicode(false);

            modelBuilder.Entity<ES_NhomNhanSu>()
                .Property(e => e.MaNhom)
                .IsUnicode(false);

            modelBuilder.Entity<Express_CongTyChuyenPhat>()
                .Property(e => e.PhuPhiXangDau)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Express_DeXuatChuyenPhat>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Express_DeXuatChuyenPhat>()
                .Property(e => e.TienDongGoi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Express_DeXuatChuyenPhat>()
                .Property(e => e.PhuPhi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Express_DeXuatChuyenPhat>()
                .Property(e => e.VAT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Express_GiaCPN>()
                .Property(e => e.NoiTinh)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Express_GiaCPN>()
                .Property(e => e.Den300km)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Express_GiaCPN>()
                .Property(e => e.Tren300km)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HoiDap_CauHoi>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<HoiDap_DonVi>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<HoiDap_LinhVuc>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<HoiDap_LinhVuc>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<HT_LichSuDangNhap>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<HT_LichSuThaoTac>()
                .Property(e => e.FullController)
                .IsUnicode(false);

            modelBuilder.Entity<HT_LichSuThaoTac>()
                .Property(e => e.TenController)
                .IsUnicode(false);

            modelBuilder.Entity<HT_LichSuThaoTac>()
                .Property(e => e.TenAction)
                .IsUnicode(false);

            modelBuilder.Entity<HT_LichSuThaoTac>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<HT_LichSuThaoTac>()
                .Property(e => e.DBHRM)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_BangCap>()
                .Property(e => e.MaBangCap)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_CapBac>()
                .Property(e => e.MaCapBac)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_DiaDiem>()
                .Property(e => e.MaDiaDiem)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_KhoaDaoTao>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_LoaiHinhCongViec>()
                .Property(e => e.MaLoaiHinh)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_MucLuong>()
                .Property(e => e.MucLuongTu)
                .HasPrecision(18, 0);

            modelBuilder.Entity<JOB_MucLuong>()
                .Property(e => e.MucLuongDen)
                .HasPrecision(18, 0);

            modelBuilder.Entity<JOB_NganhNghe>()
                .Property(e => e.MaNganh)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_NgonNgu>()
                .Property(e => e.MaNgonNgu)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_Truong>()
                .Property(e => e.MaTruong)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_ViecLam>()
                .Property(e => e.MaCongViec)
                .IsUnicode(false);

            modelBuilder.Entity<JOB_XepLoai>()
                .Property(e => e.MaXepLoai)
                .IsUnicode(false);

            modelBuilder.Entity<KH_DotRelease>()
                .Property(e => e.MaRelease)
                .IsUnicode(false);

            modelBuilder.Entity<KH_YeuCau>()
                .Property(e => e.MaYeuCau)
                .IsUnicode(false);

            modelBuilder.Entity<SV_NhatKyVaoTruong>()
                .Property(e => e.IDLichHocList)
                .IsUnicode(false);

            modelBuilder.Entity<SV_NhatKyVaoTruong>()
                .Property(e => e.IDLichThiList)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_BieuMau>()
                .Property(e => e.MaBieuMau)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_BieuMau>()
                .Property(e => e.CheckSum)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CaiDatCauHinh>()
                .Property(e => e.KeyCauHinh)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CauHinh>()
                .Property(e => e.KeyCauHinh)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CauHinh>()
                .Property(e => e.ElementsCSS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CauHinh>()
                .Property(e => e.MaNhom)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Config>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MailContent>()
                .Property(e => e.DsIDMail)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Menu>()
                .Property(e => e.TenController)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Menu>()
                .Property(e => e.TenAction)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Menu>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MenuActive>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_NhomCauHinh>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_NhomCauHinh>()
                .Property(e => e.MaGiaoDien)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Resource>()
                .Property(e => e.KeyResource)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SetConfig>()
                .Property(e => e.KeyConfig)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_TableImport>()
                .Property(e => e.TenTable)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_TableImportDetail>()
                .Property(e => e.TenField)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_TableImportDetail>()
                .Property(e => e.LoaiDuLieu)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_TableImportDetail>()
                .Property(e => e.GiaTriMin)
                .HasPrecision(36, 6);

            modelBuilder.Entity<SYS_TableImportDetail>()
                .Property(e => e.GiaTriMax)
                .HasPrecision(36, 6);

            modelBuilder.Entity<SYS_TableImportDetail>()
                .Property(e => e.NgayFormat)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ThongKeTruyCapDetail>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_TimeLine>()
                .Property(e => e.IconClass)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_TimeLine>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<TAX_TrangThaiXuLy>()
                .Property(e => e.MaTrangThai)
                .IsUnicode(false);

            modelBuilder.Entity<TEL_DangKyDienThoai>()
                .Property(e => e.DinhMuc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TEL_DM_GoiCuoc>()
                .Property(e => e.SoTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TEL_TienDienThoai>()
                .Property(e => e.DinhMuc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TEL_TienDienThoai>()
                .Property(e => e.ThucTe)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TEL_TienDienThoai>()
                .Property(e => e.TienXinGiam)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TEL_TienDienThoai>()
                .Property(e => e.TienDuocDuyet)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TNTS_KetQua>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<TSHN_DM_Khoa>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<TSHN_DM_Khoa>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<TSHN_DM_Khoa>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TSHN_DM_Nganh>()
                .Property(e => e.MaNganh)
                .IsUnicode(false);

            modelBuilder.Entity<TSHN_DM_Nganh>()
                .Property(e => e.MaTuyenSinh)
                .IsUnicode(false);

            modelBuilder.Entity<TSHN_DM_Nghe>()
                .Property(e => e.MaNghe)
                .IsUnicode(false);

            modelBuilder.Entity<TSHN_TinTuc>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<VBDH_CoQuan>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<VBDH_CoQuan>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<VBDH_DM_LoaiVanBanLienQuan>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<VBDH_DM_LoaiVanBanLienQuan>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<VBDH_LinhVuc>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<VBDH_LoaiVanBan>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<VBDH_NhomVanBan>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<VBDH_TrangThai>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<VBDH_VanBan>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<VBPL_CoQuan>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<VBPL_CoQuan>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<VBPL_LinhVuc>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<VBPL_LinhVuc>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<VBPL_LoaiVanBan>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<VBPL_LoaiVanBan>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<VBPL_Nganh>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<VBPL_Nganh>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<VBPL_PhamVi>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<VBPL_TrangThai>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<VBPL_VanBan>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<Xe_XeOTo>()
                .Property(e => e.DinhMuc)
                .HasPrecision(18, 0);
        }
    }
}
