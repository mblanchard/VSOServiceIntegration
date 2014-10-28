using System.Collections.Generic;
using RestSharp;
using VSOServiceIntegration.Common.ServiceConfig;
using VSOServiceIntegration.Entities;
using VSOServiceIntegration.Entities.VSO;
using VSOServiceIntegration.Services.Rest.Interfaces;

namespace VSOServiceIntegration.Services.Rest
{
    public class VSOService: BaseRestService, IVSOService
    {

        #region Constructors
        public VSOService(ServiceElement service) : base(service)
        {
        }

      
        #endregion Constructors

        public List<Subscription> GetSubscriptions()
        {
            var subscriptions = new List<Subscription>();
            return subscriptions;
        }

    }
}
