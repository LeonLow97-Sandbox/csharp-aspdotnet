using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class TwoFactorAuth : Controller
    {
        // 
        // GET: /TwoFactorAuth/

        public IActionResult Index()
        {
            return View();
        }
    }
}

