using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSOServiceIntegration.Entities.VSO;

namespace VSOServiceIntegration.Entities.VSO
{
    public class Subscription
    {
        public string consumerActionId { get; set; }
        public string consumerId { get; set; }
        public string eventType { get; set; }
        public string publisherId { get; set; }
        public PublisherInputs publisherInputs { get; set; }
        public ConsumerInputs consumerInputs { get; set; }
    }
}
