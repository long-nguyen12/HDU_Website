using HDU_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HDU_Website.Controllers
{
    public class HomeController : Controller
    {
        DBConnection dbConnection = new DBConnection();
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult TinNoiBat()
        {
            var tinNoiBatModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == 1 && n.IDDanhMuc == 7 && n.IsDelete != true).OrderByDescending(n => n.ID).Take(4).ToList();
            return PartialView(tinNoiBatModel);
        }

        [ChildActionOnly]
        public ActionResult TinMoi()
        {
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == 1 && n.IDDanhMuc == 1 && n.IsDelete != true).OrderByDescending(n => n.ID).Take(6).ToList();
            return PartialView(tinMoiModel);
        }

        [ChildActionOnly]
        public ActionResult TinVan()
        {
            var tinMoiModel = dbConnection.CMS_TinTuc.Where(n => n.IsHienThi == true && n.ForWeb == 1 && n.IDDanhMuc == 1 && n.IsDelete != true).OrderByDescending(n => n.ID).Take(4).ToList();
            return PartialView(tinMoiModel);
        }

        [ChildActionOnly]
        public ActionResult Video (String sectionType) {
            var videoModel = (dynamic) null;
            if (sectionType.Equals("VideoList"))
            {
                videoModel = dbConnection.CMS_Video.Where(n => n.IsHienThi == true && n.ForWeb == 1 && n.IsDelete != true).OrderByDescending(n => n.ID).Take(10).ToList();
            }
            return PartialView(videoModel);
        }
    }
}