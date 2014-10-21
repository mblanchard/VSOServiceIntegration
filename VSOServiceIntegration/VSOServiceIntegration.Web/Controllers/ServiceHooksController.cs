using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace VSOServiceIntegration.Web.Controllers
{
    public class ServiceController : ApiController
    {
        [System.Web.Http.HttpPost]
        public ActionResult VSO([FromBody] string value)
        {
            return new HttpStatusCodeResult(200, value);
        }
    }
}
