using System;
using Autofac.Core;
using RestSharp;
using VSOServiceIntegration.Common.ServiceConfig;

namespace VSOServiceIntegration.Services.Rest
{
    public class BaseRestService: IRestService
    {
        //protected ServiceElement _serviceConfig;
        protected RestClient _restClient;
        protected ServiceElement _serviceConfig;


        #region Constructors
        public BaseRestService() { }

        public BaseRestService(ServiceElement service)
        {
            Init(service);
        }

        #endregion Constructors


        #region Public Methods

        public void Init(ServiceElement service)
        {
            if (service != null)
            {
                _serviceConfig = service;
                _restClient = new RestClient(service.BaseUrl);
            }
        }
     
        public bool HttpAuthenticate(string username, string password)
        {
            if (_restClient != null)
            {
                _restClient.Authenticator = new HttpBasicAuthenticator(username, password);
                return true;
            }
            return false;
        }

        public string GetAuthenticationUrl(string redirectUri)
        {
            if (_serviceConfig != null && redirectUri != null)
            {
                var authUrl = _serviceConfig.AuthUrl;
                return String.Format(authUrl, _serviceConfig.ClientId, redirectUri);
            }
            return null;
        }


        public bool Authenticate(string redirectUri)
        {
            var authUrl = GetAuthenticationUrl(redirectUri);
            var request = new RestRequest(authUrl, Method.POST);
            var response = _restClient.Execute(request);
            return true;
        }

        #endregion Public Methods

    }
}
