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

        // GET: Footer
        public ActionResult Index()
        {
            int forweb = getForWeb();
            var rightNews = dbConnection.SYS_CaiDatCauHinh.Where(n => n.ForWeb == forweb).ToList();
            return PartialView(rightNews);
        }
    }
}