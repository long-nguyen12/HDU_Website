using HDU_Website.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;

namespace HDU_Website.Controllers
{
    public class NewsRouterViewModel
    {
        public CMS_TinTuc News { get; set; }
        public CMS_Router Router { get; set; }

        public DM_TinTuc DanhMuc { get; set; }
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

    public class HomeController : Controller
    {
        DBConnection dbConnection = new DBConnection();
        public ActionResult Index()
        {
            var configs = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == 1);
            return View(configs);
        }

        [ChildActionOnly]
        public ActionResult TinMoiHome(int id)
        {
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == 1 && n.IDDanhMuc == id && n.IsDelete != true).OrderByDescending(n => n.ID).Take(5).ToList();
            var routerList = dbConnection.CMS_Router.ToList();
            var danhMucList = dbConnection.DM_TinTuc.ToList();
            var newsRouters = from n in tinMoiModel
                              join r in routerList on n.ID equals r.IDMap
                              join d in danhMucList on n.IDDanhMuc equals d.ID
                              select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };
            ViewBag.IDGroup = id;
            return PartialView(newsRouters);
        }

        [ChildActionOnly]
        public ActionResult TinMoi(int id, string tieude)
        {
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == 1 && n.IDDanhMuc == id && n.IsDelete != true).OrderByDescending(n => n.ID).Take(10).ToList();
            var routerList = dbConnection.CMS_Router.ToList();
            var danhMucList = dbConnection.DM_TinTuc.ToList();
            var newsRouters = from n in tinMoiModel
                              join r in routerList on n.ID equals r.IDMap
                              join d in danhMucList on n.IDDanhMuc equals d.ID
                              select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };
            var danhmuc = dbConnection.DM_TinTuc.Where(n => n.ID == id).FirstOrDefault();
            ViewBag.NewsGroup = danhmuc.TenDanhMuc;
            ViewBag.IDGroup = id;
            return PartialView(newsRouters);
        }

        [ChildActionOnly]
        public ActionResult TinHome(int id, int total)
        {
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == 1 && n.IDDanhMuc == id && n.IsDelete != true).OrderByDescending(n => n.ID).Take(total).ToList();
            var routerList = dbConnection.CMS_Router.ToList();
            var danhMucList = dbConnection.DM_TinTuc.ToList();
            var newsRouters = from n in tinMoiModel
                              join r in routerList on n.ID equals r.IDMap
                              join d in danhMucList on n.IDDanhMuc equals d.ID
                              select new NewsRouterViewModel { News = n, Router = r, DanhMuc = d };
            var danhmuc = dbConnection.DM_TinTuc.Where(n => n.ID == id).FirstOrDefault();
            ViewBag.NewsGroup = danhmuc.TenDanhMuc;
            ViewBag.IDGroup = id;
            return PartialView(newsRouters);
        }

        [ChildActionOnly]
        public ActionResult Video(String sectionType)
        {
            var videoModel = (dynamic)null;
            if (sectionType.Equals("VideoList"))
            {
                videoModel = dbConnection.CMS_Video.Where(n => n.IsHienThi == true && n.ForWeb == 1 && n.IsDelete != true).OrderByDescending(n => n.ID).Take(10).ToList();
            }
            return PartialView(videoModel);
        }

        [ChildActionOnly]
        public ActionResult ThuVienAnh(int idAlbum)
        {
            var photoModel = dbConnection.CMS_ThuVienAnh.Where(n => n.IDAlbum == idAlbum).ToList();
            var fileModel = dbConnection.FILE_QuanLyFile.Where(n => n.IsDelete != true).ToList();
            var photoList = from n in photoModel
                            join r in fileModel on n.IDFile equals r.ID
                            select new GalleryViewModel { Gallery = n, FileAnh = r };
            return PartialView(photoList);
        }


        public ActionResult DaoTao(int idDanhMuc, int? page)
        {
            if (page == null) page = 1;

            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == 1 && n.IDDanhMuc == idDanhMuc).OrderByDescending(n => n.ID).ToList();
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


        public ActionResult TimKiem(string query, int? page)
        {
            if (page == null) page = 1;

            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == 1 && n.TieuDe.Contains(query)).OrderByDescending(n => n.ID).ToList();
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

        public ActionResult ChiTietTinTuc(int id)
        {
            var chiTiet = dbConnection.CMS_TinTuc.FirstOrDefault(t => t.ID == id);
            var r = dbConnection.CMS_Router.FirstOrDefault(t => t.IDMap == chiTiet.ID);
            var d = dbConnection.DM_TinTuc.FirstOrDefault(t => t.ID == chiTiet.IDDanhMuc);
            var newsRouters = new NewsRouterViewModel { News = chiTiet, Router = r, DanhMuc = d };
            return View(newsRouters);
        }

        public ActionResult GioiThieu(int id)
        {
            var baiViet = dbConnection.CMS_BaiViet.FirstOrDefault(t => t.ID == id);
            return View(baiViet);
        }
    }
}