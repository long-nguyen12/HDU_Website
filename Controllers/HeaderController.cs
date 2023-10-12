using HDU_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;

namespace HDU_Website.Controllers
{
    public class HeaderController : Controller
    {
        DBConnection dbConnection = new DBConnection();
        // GET: Header
        [ChildActionOnly]
        public ActionResult Header()
        {
            var header = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == 1).ToList();
            return PartialView(header);
        }

        [ChildActionOnly]
        public ActionResult Menu()
        {
            var IDNhom = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == 1 && n.KeyCauHinh.Equals("TH1065DF_Header_Menu")).FirstOrDefault();
            if(IDNhom != null)
            {
                int id = int.Parse(IDNhom.ValueCauHinh);
                var menuModel = dbConnection.CMS_Menu.Where(n => n.IDNhom == 1 && n.ForWeb == id).ToList();
                return PartialView(menuModel);
            }
            return PartialView();
        }
        public JsonResult GetMenu()
        {
            var IDNhom = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == 1 && n.KeyCauHinh.Equals("TH1065DF_Header_Menu")).FirstOrDefault();
            if (IDNhom != null)
            {
                int id = int.Parse(IDNhom.ValueCauHinh);
                var menuModel = dbConnection.CMS_Menu.Where(n => n.IDNhom == id && n.ForWeb == 1).OrderBy(n => n.Ordering).ToList();
                return Json(new { success = true, data = menuModel }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false });
        }
    }
}