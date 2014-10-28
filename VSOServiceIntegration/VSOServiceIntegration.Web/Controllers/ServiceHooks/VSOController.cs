
using System;
using System.Web.Mvc;
using VSOServiceIntegration.Entities;
using VSOServiceIntegration.Entities.VSO;
using VSOServiceIntegration.Services.Rest.Interfaces;

namespace VSOServiceIntegration.Web.Controllers.ServiceHooks
{
    public class VSOController: Controller
    {
        #region Constructor
        public VSOController(IVSOService vsoService)
        {
            if (vsoService == null) throw new ArgumentNullException("vsoService");
            _vsoService = vsoService;
        }

        #endregion Constructor


        #region Private Members

        private IVSOService _vsoService;
        #endregion Private Members


        #region Action Methods
        [AllowAnonymous]
        [HttpPost]
        public ActionResult ServiceHook(Event vsoEvent)
        {
         
            return new HttpStatusCodeResult(200);
        } 
        
        [AllowAnonymous]
        [HttpPost]
        public ActionResult CreateSubscription(Subscription vsoSubscription)
        {
         
            return new HttpStatusCodeResult(200);
        }

        [HttpGet]
        public ActionResult Subscriptions()
        {
            return new HttpStatusCodeResult(200, "Subscriptions");
        }

        [HttpGet]
        public ActionResult History()
        {
            return new HttpStatusCodeResult(200, "History");
        }

        #endregion Action Methods
    }
}
