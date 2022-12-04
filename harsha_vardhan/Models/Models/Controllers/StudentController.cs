using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([ModelBinder(typeof (CustomBinder))])
        {
            return View();
        }
    }
}