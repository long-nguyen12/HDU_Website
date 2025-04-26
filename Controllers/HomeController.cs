using HDU_Website.Models;
using PagedList;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Web.WebPages;

namespace HDU_Website.Controllers
{
    public class NewsRouterViewModel
    {
        public CMS_TinTuc News { get; set; }
        public CMS_Router Router { get; set; }

        public DM_TinTuc DanhMuc { get; set; }
    }
    public class BaiVietRouterViewModel
    {
        public CMS_BaiViet News { get; set; }
        public CMS_Router Router { get; set; }

        public DM_BaiViet DanhMuc { get; set; }
    }

    public class GalleryViewModel
    {
        public CMS_ThuVienAnh Gallery { get; set; }
        public FILE_QuanLyFile FileAnh { get; set; }
    }

    public class NewsListViewModel
    {
        public int IdDanhMuc { get; set; }
        public IPagedList<NewsRouterViewModel> NewsRouters { get; set; }
    }

    public class SystemConfig
    {
        public DM_TenMien TenMien { get; set; }
        public DM_Website Website { get; set; }
    }

    public class HomeController : Controller
    {
        DBConnection dbConnection = new DBConnection();

        public int getForWeb()
        {
            String host = Request.Url.Host;

            if (host.StartsWith("www."))
                host = host.Substring(4);
            var domain = dbConnection.DM_TenMien.Where(n => n.TenMien.Equals(host)).FirstOrDefault();
            if (domain != null)
            {
                int forweb = (int)domain.ForWeb;
                ViewBag.ForWeb = forweb;
                return forweb;
            }
            ViewBag.ForWeb = 1;
            return 1;
        }

        public ActionResult Index()
        {
            int forweb = getForWeb();
            var configs = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == forweb);
            return View(configs);
        }

        [ChildActionOnly]
        public ActionResult TinMoiHome(int id)
        {
            int forweb = getForWeb();
            var config = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == forweb && n.KeyCauHinh.Equals("TH1065DF_NewsTop_Left")).FirstOrDefault();
            if (config != null)
            {
                string valueConfig = config.ValueCauHinh;
                int[] intIDs = valueConfig.Split(',').Select(int.Parse).ToArray();
                var tinLeft = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == forweb && intIDs.Contains((int)n.IDDanhMuc) && n.IsDelete != true).OrderByDescending(n => n.NgayCapNhat).Take(100).ToList();
                var routerList = dbConnection.CMS_Router.ToList();
                var danhMucList = dbConnection.DM_TinTuc.ToList();
                var newsRouters = from n in tinLeft
                                  join r in routerList on n.ID equals r.IDMap
                                  join d in danhMucList on n.IDDanhMuc equals d.ID
                                  select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };
                var danhmuc = dbConnection.SYS_CaiDatCauHinh.Where(n => n.KeyCauHinh.Equals("TH1065DF_NewsTop_LeftLabel") && n.ForWeb == forweb).FirstOrDefault();
                if (danhmuc != null)
                {
                    ViewBag.NewsGroup = danhmuc.ValueCauHinh;
                    if (intIDs.Length > 0)
                    {
                        int lastItem = intIDs[0];
                        ViewBag.NewsIDGroup = lastItem;
                    }
                }
                return PartialView(newsRouters);
            }
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult TinMoi()
        {
            int forweb = getForWeb();
            var config = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == forweb && n.KeyCauHinh.Equals("TH1065DF_NewsTop_Right")).FirstOrDefault();
            if (config != null)
            {
                string valueConfig = config.ValueCauHinh;
                int[] intIDs = valueConfig.Split(',').Select(int.Parse).ToArray();
                var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == forweb && intIDs.Contains((int)n.IDDanhMuc) && n.IsDelete != true).OrderByDescending(n => n.NgayCapNhat).Take(5).ToList();
                var routerList = dbConnection.CMS_Router.ToList();
                var danhMucList = dbConnection.DM_TinTuc.ToList();
                var newsRouters = from n in tinMoiModel
                                  join r in routerList on n.ID equals r.IDMap
                                  join d in danhMucList on n.IDDanhMuc equals d.ID
                                  select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };
                var danhmuc = dbConnection.SYS_CaiDatCauHinh.Where(n => n.KeyCauHinh.Equals("TH1065DF_NewsTop_RightLabel") && n.ForWeb == forweb).FirstOrDefault();
                if (danhmuc != null)
                {
                    ViewBag.NewsGroup = danhmuc.ValueCauHinh;
                    if (intIDs.Length > 0)
                    {
                        int lastItem = intIDs[0];
                        ViewBag.IDGroup = lastItem;
                    }
                }
                return PartialView(newsRouters);
            }
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult TinNoiBat(int id)
        {
            int forweb = getForWeb();
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.IsNoiBat == true && n.ForWeb == forweb && n.IsDelete != true).OrderByDescending(n => n.NgayCapNhat).Take(5).ToList();
            var routerList = dbConnection.CMS_Router.ToList();
            var danhMucList = dbConnection.DM_TinTuc.ToList();
            var newsRouters = from n in tinMoiModel
                              join r in routerList on n.ID equals r.IDMap
                              join d in danhMucList on n.IDDanhMuc equals d.ID
                              select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };
            var danhmuc = dbConnection.SYS_CaiDatCauHinh.Where(n => n.KeyCauHinh.Equals("TH1065DF_NewsTop_HotNewLabel") && n.ForWeb == forweb).FirstOrDefault();
            if (danhmuc != null)
            {
                ViewBag.NewsGroup = danhmuc.ValueCauHinh;
            }
            if (newsRouters != null)
                return PartialView(newsRouters);
            return PartialView();
        }

        // TinMoiCTTinTuc - Menu Right Tin tuc trong chi tiet tin tuc
        [ChildActionOnly]
        public ActionResult TinMoiCTTinTuc()
        {
            int forweb = getForWeb();
            var config = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == forweb && n.KeyCauHinh.Equals("TH1065DF_NewsTop_Right")).FirstOrDefault();
            if (config != null)
            {
                string valueConfig = config.ValueCauHinh;
                int[] intIDs = valueConfig.Split(',').Select(int.Parse).ToArray();
                var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == forweb && intIDs.Contains((int)n.IDDanhMuc) && n.IsDelete != true).OrderByDescending(n => n.NgayCapNhat).Take(10).ToList();
                var routerList = dbConnection.CMS_Router.ToList();
                var danhMucList = dbConnection.DM_TinTuc.ToList();
                var newsRouters = from n in tinMoiModel
                                  join r in routerList on n.ID equals r.IDMap
                                  join d in danhMucList on n.IDDanhMuc equals d.ID
                                  select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };
                var danhmuc = dbConnection.SYS_CaiDatCauHinh.Where(n => n.KeyCauHinh.Equals("TH1065DF_NewsTop_RightLabel") && n.ForWeb == forweb).FirstOrDefault();
                if (danhmuc != null)
                {
                    ViewBag.NewsGroup = danhmuc.ValueCauHinh;
                    if (intIDs.Length > 0)
                    {
                        int lastItem = intIDs[0];
                        ViewBag.IDGroup = lastItem;
                    }
                }
                return PartialView(newsRouters);
            }
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult TinNoiBatCTTinTuc(int id, string tieude, bool noibat)
        {
            int forweb = getForWeb();
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.IsNoiBat == noibat && n.ForWeb == forweb && n.IsDelete != true).OrderByDescending(n => n.NgayCapNhat).Take(10).ToList();
            var routerList = dbConnection.CMS_Router.ToList();
            var danhMucList = dbConnection.DM_TinTuc.ToList();
            var newsRouters = from n in tinMoiModel
                              join r in routerList on n.ID equals r.IDMap
                              join d in danhMucList on n.IDDanhMuc equals d.ID
                              select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };
            var danhmuc = dbConnection.SYS_CaiDatCauHinh.Where(n => n.KeyCauHinh.Equals("TH1065DF_NewsTop_HotNewLabel") && n.ForWeb == forweb).FirstOrDefault();
            if (danhmuc != null)
            {
                ViewBag.NewsGroup = danhmuc.ValueCauHinh;
            }
            return PartialView(newsRouters);
        }

        [ChildActionOnly]
        public ActionResult TinLienQuanCTTinTuc(int id, string tieude)
        {
            int forweb = getForWeb();
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.IDDanhMuc == id && n.IsNoiBat == false && n.ForWeb == forweb && n.SoThuTu > 0 && n.IsDelete != true).OrderByDescending(n => n.NgayCapNhat).Take(20).ToList();
            var routerList = dbConnection.CMS_Router.ToList();
            var danhMucList = dbConnection.DM_TinTuc.ToList();
            var newsRouters = from n in tinMoiModel
                              join r in routerList on n.ID equals r.IDMap
                              join d in danhMucList on n.IDDanhMuc equals d.ID
                              select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };

            ViewBag.IDGroup = id;
            if (tieude != null)
            {

                ViewBag.NewsGroup = tieude;
            }
            else
            {
                var danhmuc = dbConnection.DM_TinTuc.Where(n => n.ID == id && n.ForWeb == forweb).FirstOrDefault();
                if (danhmuc != null)
                {
                    ViewBag.NewsGroup = danhmuc.TenDanhMuc;
                }
            }
            return PartialView(newsRouters);
        }

        [ChildActionOnly]
        public ActionResult TinLienQuanCTBaiViet(int id)
        {
            int forweb = getForWeb();
            var tinMoiModel = dbConnection.CMS_BaiViet.Where(n => n.IsHienThi == true && n.ForWeb == forweb && n.IsDelete != true).OrderByDescending(n => n.NgayCapNhat).Take(10).ToList();
            var routerList = dbConnection.CMS_Router.ToList();
            var newsRouters = from n in tinMoiModel
                              join r in routerList on n.ID equals r.IDMap
                              select new BaiVietRouterViewModel { News = n, Router = r, DanhMuc = null };
            ViewBag.NewsGroup = "Tin liên quan";
            return PartialView(newsRouters);
        }

        [ChildActionOnly]
        public ActionResult TinHome(int id, int total)
        {
            int forweb = getForWeb();
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == forweb && n.IDDanhMuc == id && n.IsDelete != true).OrderByDescending(n => n.NgayCapNhat).Take(total).ToList();
            var routerList = dbConnection.CMS_Router.ToList();
            var danhMucList = dbConnection.DM_TinTuc.ToList();
            var newsRouters = from n in tinMoiModel
                              join r in routerList on n.ID equals r.IDMap
                              join d in danhMucList on n.IDDanhMuc equals d.ID
                              select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };
            var danhmuc = dbConnection.DM_TinTuc.Where(n => n.ID == id).FirstOrDefault();
            if (danhmuc != null)
            {
                ViewBag.NewsGroup = danhmuc.TenDanhMuc;
                ViewBag.IDGroup = id;
            }
            return PartialView(newsRouters);
        }

        [ChildActionOnly]
        public ActionResult TinHomeSubSection(string key_id, string key_label)
        {
            int forweb = getForWeb();
            var Label = dbConnection.SYS_CaiDatCauHinh.Where(n => n.KeyCauHinh.Equals(key_label) && n.ForWeb == forweb).FirstOrDefault();
            var config = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == forweb && n.KeyCauHinh.Equals(key_id)).FirstOrDefault();
            if (config != null)
            {
                string valueConfig = config.ValueCauHinh;
                if (valueConfig != null)
                {
                    int[] intIDs = valueConfig.Split(',').Select(int.Parse).ToArray();
                    var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == forweb && intIDs.Contains((int)n.IDDanhMuc) && n.SoThuTu > 0 && n.IsDelete != true).OrderByDescending(n => n.NgayHienThi).Take(5).ToList();
                    var routerList = dbConnection.CMS_Router.ToList();
                    var danhMucList = dbConnection.DM_TinTuc.ToList();
                    var newsRouters = from n in tinMoiModel
                                      join r in routerList on n.ID equals r.IDMap
                                      join d in danhMucList on n.IDDanhMuc equals d.ID
                                      select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };
                    if (Label != null)
                    {
                        ViewBag.NewsGroup = Label.ValueCauHinh;
                        if (intIDs.Length > 0)
                        {
                            int lastItem = intIDs[0];
                            ViewBag.NewsIDGroup = lastItem;
                        }
                    }
                    return PartialView(newsRouters);
                }
                return PartialView();
            }
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Video(String sectionType)
        {
            int forweb = getForWeb();
            var videoType = (dynamic)null;
            videoType = dbConnection.CMS_LoaiVideo.Where(n => n.IsHienThi == true && n.ForWeb == forweb && n.IsDelete != true).FirstOrDefault();

            var videoModel = (dynamic)null;
            if (sectionType.Equals("VideoList"))
            {
                if (videoType != null)
                {
                    int typeID = videoType.ID;
                    videoModel = dbConnection.CMS_Video.Where(n => n.IsHienThi == true && n.ForWeb == forweb && n.IDLoai == typeID && n.IsDelete != true).OrderByDescending(n => n.ID).Take(10).ToList();
                }
                else
                {
                    videoModel = dbConnection.CMS_Video.Where(n => n.IsHienThi == true && n.ForWeb == forweb && n.IsDelete != true).OrderByDescending(n => n.ID).Take(10).ToList();
                }
            }
            return PartialView(videoModel);
        }

        [ChildActionOnly]
        public ActionResult ThuVienAnh()
        {
            int forweb = getForWeb();
            var ThuVien = dbConnection.SYS_CaiDatCauHinh.FirstOrDefault(n => n.KeyCauHinh == "TH1065DF_Media_Gallery" && n.ForWeb == forweb);
            if (ThuVien != null && !ThuVien.ValueCauHinh.Trim().IsEmpty())
            {
                int idAlbum = int.Parse(ThuVien.ValueCauHinh);
                var photoModel = dbConnection.CMS_ThuVienAnh.Where(n => n.IDAlbum == idAlbum).ToList();
                var fileModel = dbConnection.FILE_QuanLyFile.Where(n => n.IsDelete != true).ToList();
                var photoList = from n in photoModel
                                join r in fileModel on n.IDFile equals r.ID
                                select new GalleryViewModel { Gallery = n, FileAnh = r };
                return PartialView(photoList);
            }
            return PartialView();
        }

        public ActionResult DaoTao(int idDanhMuc, int? page)
        {
            if (page == null) page = 1;

            int forweb = getForWeb();
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == forweb && n.IDDanhMuc == idDanhMuc).OrderByDescending(n => n.ID).ToList();
            var routerList = dbConnection.CMS_Router.ToList();
            var danhMucList = dbConnection.DM_TinTuc.ToList();
            var newsRouters = from n in tinMoiModel
                              join r in routerList on n.ID equals r.IDMap
                              join d in danhMucList on n.IDDanhMuc equals d.ID
                              where n.IsDelete != true
                              select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };

            int pageSize = 10;
            int pageNumber = (page ?? 1);

            var viewModel = new NewsListViewModel
            {
                IdDanhMuc = idDanhMuc,
                NewsRouters = newsRouters.ToPagedList(pageNumber, pageSize)
            };

            return View(viewModel);
        }

        public ActionResult DanhMuc(int idDanhMuc, int? page)
        {
            int forweb = getForWeb();
            var news = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == forweb && n.IDDanhMuc == idDanhMuc).OrderByDescending(n => n.ID).ToList();
            if (news.Count == 1)
            {
                var topNews = news.Take(1).FirstOrDefault();
                var router = dbConnection.CMS_Router.Where(n => n.IDMap == topNews.ID).FirstOrDefault();
                return RedirectToAction("GetTinTucByAlias", new { alias = router.Alias });
            }
            var danhmuc = dbConnection.DM_TinTuc.Where(n => n.ID == idDanhMuc).FirstOrDefault();
            if (danhmuc != null)
            {
                ViewBag.NewsGroup = danhmuc.TenDanhMuc;
                ViewBag.IDGroup = idDanhMuc;
            }

            return View();
        }

        [ChildActionOnly]
        public ActionResult DanhMucTop(int idDanhMuc)
        {
            int forweb = getForWeb();
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == forweb && n.IDDanhMuc == idDanhMuc && n.SoThuTu == 0).FirstOrDefault();
            if (tinMoiModel != null)
            {
                var routerList = dbConnection.CMS_Router.Where(n => n.IDMap == tinMoiModel.ID).FirstOrDefault();
                var danhMucList = dbConnection.DM_TinTuc.Where(n => n.ID == tinMoiModel.IDDanhMuc).FirstOrDefault();
                var top = new NewsRouterViewModel { News = tinMoiModel, Router = routerList, DanhMuc = danhMucList };
                return PartialView(top);
            }
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult DanhMucList(int idDanhMuc, int? page)
        {
            if (page == null) page = 1;

            int forweb = getForWeb();
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == forweb && n.IDDanhMuc == idDanhMuc && n.SoThuTu != 0).OrderByDescending(n => n.ID).ToList();
            var routerList = dbConnection.CMS_Router.ToList();
            var danhMucList = dbConnection.DM_TinTuc.ToList();
            var newsRouters = from n in tinMoiModel
                              join r in routerList on n.ID equals r.IDMap
                              join d in danhMucList on n.IDDanhMuc equals d.ID
                              where n.IsDelete != true
                              select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };

            int pageSize = 10;
            int pageNumber = (page ?? 1);

            var viewModel = new NewsListViewModel
            {
                IdDanhMuc = idDanhMuc,
                NewsRouters = newsRouters.ToPagedList(pageNumber, pageSize)
            };
            var danhmuc = dbConnection.DM_TinTuc.Where(n => n.ID == idDanhMuc).FirstOrDefault();
            if (danhmuc != null)
            {
                ViewBag.NewsGroup = danhmuc.TenDanhMuc;
                ViewBag.IDGroup = idDanhMuc;
            }

            return PartialView(viewModel);
        }

        public ActionResult TimKiem(string query, int? page)
        {
            if (page == null) page = 1;

            int forweb = getForWeb();
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == forweb && n.TieuDe.Contains(query)).OrderByDescending(n => n.ID).ToList();
            var routerList = dbConnection.CMS_Router.ToList();
            var danhMucList = dbConnection.DM_TinTuc.ToList();
            var newsRouters = from n in tinMoiModel
                              join r in routerList on n.ID equals r.IDMap
                              join d in danhMucList on n.IDDanhMuc equals d.ID
                              where n.IsDelete != true
                              select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };

            int pageSize = 10;
            int pageNumber = (page ?? 1);

            var viewModel = new NewsListViewModel
            {
                NewsRouters = newsRouters.ToPagedList(pageNumber, pageSize)
            };
            ViewBag.query = query;
            return View(viewModel);
        }

        public ActionResult GetTinTucByAlias(string alias)
        {
            alias = alias.Replace(".html", "");
            int forweb = getForWeb();
            var r = dbConnection.CMS_Router.FirstOrDefault(t => t.Alias.Equals(alias) && t.ForWeb == forweb);
            var chiTiet = dbConnection.CMS_TinTuc.Where(t => t.ID == r.IDMap).FirstOrDefault();
            if (chiTiet != null)
            {
                var d = dbConnection.DM_TinTuc.FirstOrDefault(t => t.ID == chiTiet.IDDanhMuc);
                var file = dbConnection.CMS_TinTucFileAttach.Where(t => t.IDTinTuc == chiTiet.ID).ToList();
                if (file != null)
                {
                    var fileUrl = "";
                    for (var i = 0; i < file.Count; i++)
                    {
                        var item = file[i];
                        var attachFile = dbConnection.FILE_QuanLyFile.FirstOrDefault(t => t.ID == item.IDFile);
                        if (i != file.Count - 1)
                        {
                            fileUrl += attachFile.TenFileMoi + ",";
                        }
                        else
                        {
                            fileUrl += attachFile.TenFileMoi;
                        }
                    }
                    ViewBag.fileUrl = fileUrl.Replace('\\', '/');
                }
                var newsRouters = new NewsRouterViewModel { News = chiTiet, Router = r, DanhMuc = d };
                var configs = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == forweb);
                var newsArea = configs.FirstOrDefault(n => n.KeyCauHinh == "TH1065DF_NewsTop_Right");
                ViewBag.valueCauHinh = newsArea.ValueCauHinh;
                return View(newsRouters);
            }
            else
            {
                return RedirectToAction("GetBaiVietByAlias", new { alias = alias });
            }

        }

        public ActionResult GetBaiVietByAlias(string alias)
        {
            alias = alias.Replace(".html", "");
            var r = dbConnection.CMS_Router.FirstOrDefault(t => t.Alias.Equals(alias));
            var BaiViet = dbConnection.CMS_BaiViet.FirstOrDefault(t => t.ID == r.IDMap);
            if (BaiViet != null)
            {
                var file = dbConnection.CMS_BaiVietFileAttach.FirstOrDefault(t => t.IDBaiViet == BaiViet.ID);
                if (file != null)
                {
                    var attachFile = dbConnection.FILE_QuanLyFile.FirstOrDefault(t => t.ID == file.IDFile);
                    var fileUrl = attachFile.TenFileMoi;
                    ViewBag.fileUrl = fileUrl;
                }
                var newsRouters = new BaiVietRouterViewModel { News = BaiViet, Router = r, DanhMuc = null };
                int forweb = getForWeb();
                var configs = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == forweb);
                var newsArea = configs.FirstOrDefault(n => n.KeyCauHinh == "TH1065DF_NewsTop_Right");
                ViewBag.valueCauHinh = newsArea.ValueCauHinh;
                return View(newsRouters);
            }
            else
            {
                return View();
            }
        }

        public ActionResult ChiTietTinTuc(int id)
        {
            int forweb = getForWeb();
            var chiTiet = dbConnection.CMS_TinTuc.FirstOrDefault(t => t.ID == id);
            var r = dbConnection.CMS_Router.FirstOrDefault(t => t.IDMap == chiTiet.ID);
            var d = dbConnection.DM_TinTuc.FirstOrDefault(t => t.ID == chiTiet.IDDanhMuc);
            var file = dbConnection.CMS_TinTucFileAttach.FirstOrDefault(t => t.IDTinTuc == id);
            if (file != null)
            {
                var attachFile = dbConnection.FILE_QuanLyFile.FirstOrDefault(t => t.ID == file.IDFile);
                var fileUrl = attachFile.TenFileMoi;
                ViewBag.fileUrl = fileUrl;
            }
            var newsRouters = new NewsRouterViewModel { News = chiTiet, Router = r, DanhMuc = d };
            var configs = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == forweb);
            var newsArea = configs.FirstOrDefault(n => n.KeyCauHinh == "TH1065DF_NewsTop_Right");
            ViewBag.valueCauHinh = newsArea.ValueCauHinh;
            return View(newsRouters);
        }

        public ActionResult GioiThieu(int id)
        {
            var baiViet = dbConnection.CMS_BaiViet.FirstOrDefault(t => t.ID == id);
            return View(baiViet);
        }

        public JsonResult Counting(int id)
        {
            var news = dbConnection.CMS_TinTuc.Where(n => n.ID == id).FirstOrDefault();
            if (news != null)
            {
                news.SoLuotXem = news.SoLuotXem + 1;
                dbConnection.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
        public JsonResult BaiVietCounting(int id)
        {
            var news = dbConnection.CMS_BaiViet.Where(n => n.ID == id).FirstOrDefault();
            if (news != null)
            {
                news.SoLanXem = news.SoLanXem + 1;
                dbConnection.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        public JsonResult GetMenu()
        {
            int forweb = getForWeb();
            var menus = dbConnection.CMS_Menu.Where(n => n.ForWeb == forweb && n.IsDelete != true && n.IsHienThi == true).ToList();
            if (menus != null)
            {
                return Json(new { success = true, data = menus }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false });
        }
    }
}