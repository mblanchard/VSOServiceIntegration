using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSOServiceIntegration.Entities.VSO
{
    public class Event
    {
        #region Properties

        public string subscriptionId { get; set; }
        public int notificationId { get; set; }
        public string id { get; set; }
        public string eventType { get; set; }
        public string publisherId { get; set; }

        public Message message { get; set; }
        public Message detailedMessage { get; set; }
        #endregion Properties
    }

}
