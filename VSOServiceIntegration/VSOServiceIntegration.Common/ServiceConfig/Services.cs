using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSOServiceIntegration.Common.ServiceConfig
{
    public class ServiceElement : ConfigurationElement
    {


        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("base-url", IsRequired = false)]
        public string BaseUrl
        {
            get { return (string)this["base-url"]; }
            set { this["base-url"] = value; }
        }

        [ConfigurationProperty("auth-url", IsRequired = false)]
        public string AuthUrl
        {
            get { return (string)this["auth-url"]; }
            set { this["auth-url"] = value; }
        }
        
        [ConfigurationProperty("auth-token", IsRequired = false)]
        public string AuthToken
        {
            get { return (string)this["auth-token"]; }
            set { this["auth-token"] = value; }
        }
        
        [ConfigurationProperty("bearer-token", IsRequired = false)]
        public string BearerToken
        {
            get { return (string)this["bearer-token"]; }
            set { this["bearer-token"] = value; }
        }
        
        [ConfigurationProperty("client-id", IsRequired = false)]
        public string ClientId
        {
            get { return (string)this["client-id"]; }
            set { this["client-id"] = value; }
        }
       
    }

    [ConfigurationCollection(typeof(ServiceElement), AddItemName = "service")]
    public class ServiceElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ServiceElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ServiceElement)element).Name;
        }
    }

    public class ServicesSection : ConfigurationSection
    {
        [ConfigurationProperty("services", IsDefaultCollection = true)]
        public ServiceElementCollection Services
        {
            get { return (ServiceElementCollection)this["services"]; }
            set { this["services"] = value; }
        }

        public static ServiceElement GetServiceByName(string name)
        {
            ServiceElement matchingService = null;
            var servicesSection = (ServicesSection) ConfigurationManager.GetSection("serviceConfig");
            if (servicesSection != null && servicesSection.Services != null)
            {
                foreach (ServiceElement service in servicesSection.Services)
                {
                    if (service.Name == name)
                    {
                        matchingService = service;
                    }
                }
            }
            return matchingService;
        }
    }
}
