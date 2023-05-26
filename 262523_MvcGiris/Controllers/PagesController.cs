using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _262523_MvcGiris.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Meeting()
        {
            return View();
        }
        public ActionResult MeetingDetail()
        {
            return View();
        }
    }
}