using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSOServiceIntegration.Entities.Slack
{
    public class Topic
    {
        public string value { get; set; }
        public string creator { get; set; }
        public string last_set { get; set; }
    }
}
