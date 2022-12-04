using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutViews.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("Home/Index")]
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("Home/About")]
        public ActionResult About()
        {
            return View();
        }

        [Route("Home/Contact")]
        public ActionResult Contact()
        {
            return View();
        }

        [Route("Home/Profile")]
        public ActionResult Profile()
        {
            return View();
        }
    }
}