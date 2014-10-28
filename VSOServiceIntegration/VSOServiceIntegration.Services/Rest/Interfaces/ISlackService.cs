using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSOServiceIntegration.Entities.Slack;

namespace VSOServiceIntegration.Services.Rest.Interfaces
{
    public interface ISlackService: IRestService
    {
        List<Channel> ListChannels(string authToken);
        bool PostToChannel(string authToken, Channel channel, Message message);
        List<Message> SearchMessages(string query);
    }
}
