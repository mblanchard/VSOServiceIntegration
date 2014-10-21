using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;


namespace VSOServiceIntegration.Web.Controllers
{
    public class ServiceHooksController : ApiController
    {
        [System.Web.Mvc.HttpPost]
        public ActionResult VSO([FromBody] string value)
        {
            return new HttpStatusCodeResult(200, value);
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult VSO()
        {
            return new HttpStatusCodeResult(200);
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Slack([FromBody] string value)
        {
            return new HttpStatusCodeResult(200, value);
        }
    }
}
