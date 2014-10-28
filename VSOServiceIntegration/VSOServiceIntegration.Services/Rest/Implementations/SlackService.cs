using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSOServiceIntegration.Common.ServiceConfig;
using VSOServiceIntegration.Services.Rest.Interfaces;

namespace VSOServiceIntegration.Services.Rest.Implementations
{
    public class SlackService: BaseRestService, ISlackService
    {
        public SlackService()
        {
            var service = ServicesSection.GetServiceByName("Slack");
            Init(service);
        }

        public List<Entities.Slack.Channel> ListChannels(string authToken)
        {
            throw new NotImplementedException();
        }

        public bool PostToChannel(string authToken, Entities.Slack.Channel channel, Entities.Slack.Message message)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Slack.Message> SearchMessages(string query)
        {
            throw new NotImplementedException();
        }
    }
}
