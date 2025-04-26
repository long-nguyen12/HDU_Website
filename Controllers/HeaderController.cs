using HDU_Website.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace HDU_Website.Controllers
{
    public class HeaderController : Controller
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
                return forweb;
            }
            return 1;
        }

        // GET: Header
        [ChildActionOnly]
        public ActionResult Header()
        {
            int forweb = getForWeb();
            var header = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == forweb).ToList();
            return PartialView(header);
        }

        [ChildActionOnly]
        public ActionResult Menu()
        {
            int forweb = getForWeb();
            var IDNhom = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == forweb && n.KeyCauHinh.Equals("TH1065DF_Header_Menu")).FirstOrDefault();
            if (IDNhom != null)
            {
                int id = int.Parse(IDNhom.ValueCauHinh);
                var menuModel = dbConnection.CMS_Menu.Where(n => n.IDNhom == 1 && n.ForWeb == id).ToList();
                return PartialView(menuModel);
            }
            return PartialView();
        }
        public JsonResult GetMenu()
        {
            int forweb = getForWeb();
            var IDNhom = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == forweb && n.KeyCauHinh.Equals("TH1065DF_Header_Menu")).FirstOrDefault();
            if (IDNhom != null)
            {
                int id = int.Parse(IDNhom.ValueCauHinh);
                var menuModel = dbConnection.CMS_Menu.Where(n => n.IDNhom == id && n.ForWeb == forweb).OrderBy(n => n.Ordering).ToList();
                return Json(new { success = true, data = menuModel }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false });
        }
    }
}