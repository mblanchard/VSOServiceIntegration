using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VSOServiceIntegration.Common.ServiceConfig;

namespace VSOServiceIntegration.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            var services = (ServicesSection)ConfigurationManager.GetSection("serviceConfig");
              
            return View();
        }
    }
}
