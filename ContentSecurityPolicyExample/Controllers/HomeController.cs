using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NWebsec.Mvc.HttpHeaders.Csp;

namespace ContentSecurityPolicyExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {            
            return View();
        }
        [CspFilter]
        public ActionResult Test2()
        {
            return View();
        }

        public ActionResult JqueryTemplateExample()
        {
            return View();
        }

        public ActionResult HandleBar()
        {
            return View();
        }

        public ActionResult MustacheExample()
        {
            return View();
        }

        public JsonResult Post()
        {
            return Json(new
            {
                IsSuccess = true,
                Message = "Hell World"
            });
        }
    }
}