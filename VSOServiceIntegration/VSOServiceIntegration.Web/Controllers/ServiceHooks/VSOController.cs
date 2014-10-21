
using System.Web.Http;
using System.Web.Mvc;

namespace VSOServiceIntegration.Web.Controllers.ServiceHooks
{
    public class VSOController : Controller
    {
        [System.Web.Mvc.AllowAnonymous]
        [System.Web.Mvc.HttpPost]
        public ActionResult ServiceHook([System.Web.Http.FromBody] string value)
        {
            return new HttpStatusCodeResult(200, value);
        }


        [System.Web.Mvc.HttpGet]
        public ActionResult CheckHistory()
        {
            return new HttpStatusCodeResult(200, "History");
        }
    }
}
