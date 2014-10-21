
using System.Web.Mvc;

namespace VSOServiceIntegration.Web.Controllers.ServiceHooks
{
    public class VSOController : Controller
    {
        [HttpPost]
        public ActionResult ServiceHook([System.Web.Http.FromBody] string value)
        {
            return new HttpStatusCodeResult(200, value);
        }

        [HttpPost]
        public ActionResult ServiceHook()
        {
            return new HttpStatusCodeResult(200);
        }


        [HttpGet]
        public ActionResult CheckHistory()
        {
            return new HttpStatusCodeResult(200, "History");
        }
    }
}
