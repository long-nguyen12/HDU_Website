using HDU_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            var header = dbConnection.SYS_CaiDatCauHinh.Where(n => n.KeyCauHinh.Equals("TH1065DF_Header_LanguageEN") && n.ForWeb == 1).FirstOrDefault();
            return PartialView(header);
        }

        [ChildActionOnly]
        public ActionResult Menu()
        {
            var menuModel = dbConnection.CMS_Menu.Where(n => n.IDNhom == 1).ToList();
            return PartialView(menuModel);
        }
    }
}