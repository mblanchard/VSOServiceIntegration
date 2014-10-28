using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using VSOServiceIntegration.Common.ServiceConfig;

namespace VSOServiceIntegration.Services.Rest
{
    public interface IRestService
    {
        void Init(ServiceElement service);

        bool HttpAuthenticate(string username, string password);

        bool Authenticate(string redirectUri);

        string GetAuthenticationUrl(string redirectUrl);

    }
}
