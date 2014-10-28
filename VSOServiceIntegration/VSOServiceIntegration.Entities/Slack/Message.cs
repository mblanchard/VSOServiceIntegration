using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSOServiceIntegration.Entities.Slack
{
    public class Message
    {
        public string type { get; set; }
        public string subtype { get; set; }
        public string ts { get; set; }
        public string user { get; set; }
        public string text { get; set; }
    }
}
