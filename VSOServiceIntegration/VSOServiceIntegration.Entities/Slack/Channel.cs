using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSOServiceIntegration.Entities.Slack
{
    public class Channel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string created { get; set; }
        public string creator { get; set; }
        public bool is_archived { get; set; }
        public bool is_member { get; set; }
        public int num_members { get; set; }
        public Topic topic { get; set; }

    }
}
