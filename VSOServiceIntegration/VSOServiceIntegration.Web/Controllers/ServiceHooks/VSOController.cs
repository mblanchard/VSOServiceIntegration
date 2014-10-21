using System.Net;
using System.Web.Http;
using System.Web.Mvc;

namespace VSOServiceIntegration.Web.Controllers.ServiceHooks
{
    public class VSOController : ApiController
    {
        [System.Web.Mvc.HttpPost]
        public ActionResult ServiceHook([FromBody] string value)
        {
            return new HttpStatusCodeResult(200, value);
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult ServiceHook()
        {
            return new HttpStatusCodeResult(200);
        }


        [System.Web.Mvc.HttpGet]
        public ActionResult CheckHistory()
        {
            return new HttpStatusCodeResult(200, "History");
        }
    }
}
