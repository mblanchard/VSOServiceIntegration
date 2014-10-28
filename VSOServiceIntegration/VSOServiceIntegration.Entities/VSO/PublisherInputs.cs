using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSOServiceIntegration.Entities.VSO
{
    public class PublisherInputs
    {
        public string buildStatus { get; set; }
        public string definitionName { get; set; }
        public string hostId { get; set; }
        public string projectId { get; set; }
        public string tfsSubscriptionId { get; set; }
    }
}
