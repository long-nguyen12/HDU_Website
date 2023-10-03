using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HDU_Website.Models;

namespace HDU_Website.Controllers
{
    public class FooterController : Controller
    {
        DBConnection dbConnection = new DBConnection();
        // GET: Footer
        public ActionResult Index()
        {
            var rightNews = dbConnection.SYS_CaiDatCauHinh.Where(n => n.KeyCauHinh.Equals("TH1065DF_Footer_Info") && n.ForWeb == 1).FirstOrDefault();
            return PartialView(rightNews);
        }
    }
}